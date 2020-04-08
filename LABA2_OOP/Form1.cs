using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.Reflection;
using ZipInterface;

namespace LABA2_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxCompany.SelectedIndex = 2;
        }
        List<Phones> Models = new List<Phones>();

        private void dataGridAndAllListsUpdate()
        {
            listBoxInfo.Items.Clear();
            listBoxInfo.Items.Add("Выберите модель.");
            dataGridView1.Rows.Clear();
            ClearTextBoxes();

            for (int i = 0; i < Models.Count; i++)
                dataGridView1.Rows.Add(Models[i].Name, Models[i].RepairStartDate, $"{Models[i].Address.City}, ул.{Models[i].Address.Street}, д.{Models[i].Address.Building}");
        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы действительно хотите удалить модель " + dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value + "?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Models.RemoveAt(dataGridView1.SelectedCells[0].RowIndex);
                    MessageBox.Show("Модель удалена!");
                }
                else
                    MessageBox.Show("Модель не удалена!");
                dataGridAndAllListsUpdate();
            }
            catch
            {
                MessageBox.Show("Выберите модель!");
            }
        }

        private void ClearTextBoxes()
        {
            textBoxName.Clear();

            textBoxCost.Clear();
            textBoxNumber.Clear();
            dateTimePicker1.Value = DateTime.Today;
            textBoxCity.Clear();
            textBoxStreet.Clear();
            textBoxBuilding.Clear();

            textBox1.Clear();

            comboBoxCompany.SelectedIndex = 0;
        }

        private void FillTextBoxes()
        {
            textBoxName.Text = Models[dataGridView1.SelectedCells[0].RowIndex].Name;

            textBoxCost.Text = Models[dataGridView1.SelectedCells[0].RowIndex].EstimatedCost.ToString();
            textBoxNumber.Text = Models[dataGridView1.SelectedCells[0].RowIndex].Number;
            dateTimePicker1.Value = Models[dataGridView1.SelectedCells[0].RowIndex].RepairStartDate;
            textBoxCity.Text = Models[dataGridView1.SelectedCells[0].RowIndex].Address.City;
            textBoxStreet.Text = Models[dataGridView1.SelectedCells[0].RowIndex].Address.Street;
            textBoxBuilding.Text = Models[dataGridView1.SelectedCells[0].RowIndex].Address.Building.ToString();


            comboBoxCompany.SelectedIndex = 0;
            if (Models[dataGridView1.SelectedCells[0].RowIndex] is Samsung)
            {
                comboBoxCompany.SelectedIndex = 1;
                Samsung curr = Models[dataGridView1.SelectedCells[0].RowIndex] as Samsung;
                textBox1.Text = curr.PhoneModel.ToString();
                checkBoxRestored.Checked = curr.Restored;
            }
            else if (Models[dataGridView1.SelectedCells[0].RowIndex] is Apple)
            {
                comboBoxCompany.SelectedIndex = 2;
                Apple curr = Models[dataGridView1.SelectedCells[0].RowIndex] as Apple;
                textBox1.Text = curr.PhoneModel.ToString();
                checkBoxRestored.Checked = curr.Restored;
            }
            else if (Models[dataGridView1.SelectedCells[0].RowIndex] is Xiaomi)
            {
                comboBoxCompany.SelectedIndex = 3;
                Xiaomi curr = Models[dataGridView1.SelectedCells[0].RowIndex] as Xiaomi;
                textBox1.Text = curr.PhoneModel.ToString();
            }
            else if (Models[dataGridView1.SelectedCells[0].RowIndex] is Huawei)
            {
                comboBoxCompany.SelectedIndex = 4;
                Huawei curr = Models[dataGridView1.SelectedCells[0].RowIndex] as Huawei;
                textBox1.Text = curr.PhoneModel.ToString();
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            listBoxInfo.Items.Clear();
            FillTextBoxes();
            try
            {

                listBoxInfo.Items.Add($"Номер: { Models[dataGridView1.SelectedCells[0].RowIndex].Number}");
                listBoxInfo.Items.Add($"Ориентировочная стоимость: { Models[dataGridView1.SelectedCells[0].RowIndex].EstimatedCost}");


                if (Models[dataGridView1.SelectedCells[0].RowIndex] is Samsung)
                {
                    Samsung curr = Models[dataGridView1.SelectedCells[0].RowIndex] as Samsung;
                    listBoxInfo.Items.Add("Фирма: Samsung");
                    listBoxInfo.Items.Add($"Модель: { curr.PhoneModel}");

                    if (curr.Restored)
                        listBoxInfo.Items.Add("Восстановлен");
                    else
                        listBoxInfo.Items.Add("Оригинальный");
                }
                else if (Models[dataGridView1.SelectedCells[0].RowIndex] is Apple)
                {
                    Apple curr = Models[dataGridView1.SelectedCells[0].RowIndex] as Apple;
                    listBoxInfo.Items.Add("Фирма: Apple");
                    listBoxInfo.Items.Add($"Модель: { curr.PhoneModel}");

                    if (curr.Restored)
                        listBoxInfo.Items.Add("Восстановлен");
                    else
                        listBoxInfo.Items.Add("Оригинальный");
                }
                else if (Models[dataGridView1.SelectedCells[0].RowIndex] is Xiaomi)
                {
                    Xiaomi curr = Models[dataGridView1.SelectedCells[0].RowIndex] as Xiaomi;
                    listBoxInfo.Items.Add("Фирма: Xiaomi");
                    listBoxInfo.Items.Add($"Модель: { curr.PhoneModel}");
                }

                else if (Models[dataGridView1.SelectedCells[0].RowIndex] is Huawei)
                {
                    Huawei curr = Models[dataGridView1.SelectedCells[0].RowIndex] as Huawei;
                    listBoxInfo.Items.Add("Фирма: Huawei");
                    listBoxInfo.Items.Add($"Модель: { curr.PhoneModel}");
                }
                else
                {
                    listBoxInfo.Items.Add("Фирма: не определена");
                    listBoxInfo.Items.Add("Модель: не определена");
                }
            }
            catch
            {
                MessageBox.Show("Выберите устройство!");
            }
        }

        private static Phones getModelsTypeByString(string modelChosen, string name, DateTime repairStartDate, string number, Address address, double estimatedCost, string phonemodel, bool restored)
        {
            if (modelChosen.Equals("Apple"))
                return new Apple(name, repairStartDate, number, address, estimatedCost, restored, phonemodel);
            else if (modelChosen.Equals("Не уточнено"))
                return new Phones(name, repairStartDate, number, address, estimatedCost);
            else if (modelChosen.Equals("Xiaomi"))
                return new Xiaomi(name, repairStartDate, number, address, estimatedCost, phonemodel);
            else if (modelChosen.Equals("Huawei"))
                return new Huawei(name, repairStartDate, number, address, estimatedCost, phonemodel);
            else if (modelChosen.Equals("Samsung"))
                return new Samsung(name, repairStartDate, number, address, estimatedCost, restored, phonemodel);
            else
                throw new Exception(modelChosen + " не существует в списке!");
        }

        private bool inputtedValues()
        {
            if (textBoxName.Text == "" || textBoxNumber.Text == "" || textBoxCost.Text == "" || textBoxCity.Text == "" ||
                textBoxStreet.Text == "" || textBoxBuilding.Text == "")
                return false;
            else
                return true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (inputtedValues())
            {
                Address currAddr;

                currAddr = new Address(textBoxCity.Text, textBoxStreet.Text, Convert.ToInt32(textBoxBuilding.Text));


                int firstParam;
                try
                {
                    firstParam = Convert.ToInt32(textBox1.Text);
                }
                catch
                {
                    firstParam = 0;
                }
                Phones model = getModelsTypeByString(comboBoxCompany.Text.ToString(), textBoxName.Text, dateTimePicker1.Value,
                    textBoxNumber.Text, currAddr, Convert.ToDouble(textBoxCost.Text), textBox1.Text, checkBoxRestored.Checked);
                Models.Add(model);
                dataGridAndAllListsUpdate();

            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }

        private void textBoxCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == true || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
                return;
            e.Handled = true;
            return;
        }

        private void comboBoxCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            labelFirst.Visible = true;


            checkBoxRestored.Visible = false;
            if (comboBoxCompany.SelectedIndex == 0)
            {
                textBox1.Visible = false;
                labelFirst.Visible = false;
            }
            else if (comboBoxCompany.SelectedIndex == 1)
            {
                labelFirst.Text = "Тип модели:";
                checkBoxRestored.Visible = true;
            }
            else if (comboBoxCompany.SelectedIndex == 2)
            {
                labelFirst.Text = "Тип модели:";
                checkBoxRestored.Visible = true;
            }
            else if (comboBoxCompany.SelectedIndex == 3)
            {
                labelFirst.Text = "Тип модели:";
                checkBoxRestored.Visible = false;
            }
            else if (comboBoxCompany.SelectedIndex == 4)
            {
                labelFirst.Text = "Тип модели:";
                checkBoxRestored.Visible = false;
            }
        }

        private void buttonClear_Click_1(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void buttonEdit_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (inputtedValues())
                {
                    Models[dataGridView1.SelectedCells[0].RowIndex].Name = textBoxName.Text;

                    Models[dataGridView1.SelectedCells[0].RowIndex].EstimatedCost = Convert.ToDouble(textBoxCost.Text);
                    Models[dataGridView1.SelectedCells[0].RowIndex].Number = textBoxNumber.Text;
                    Models[dataGridView1.SelectedCells[0].RowIndex].RepairStartDate = dateTimePicker1.Value;
                    Models[dataGridView1.SelectedCells[0].RowIndex].Address.City = textBoxCity.Text;
                    Models[dataGridView1.SelectedCells[0].RowIndex].Address.Street = textBoxStreet.Text;
                    Models[dataGridView1.SelectedCells[0].RowIndex].Address.Building = Convert.ToInt32(textBoxBuilding.Text);

                    comboBoxCompany.SelectedIndex = 0;
                    if (Models[dataGridView1.SelectedCells[0].RowIndex] is Samsung)
                    {
                        comboBoxCompany.SelectedIndex = 1;
                        Samsung curr = Models[dataGridView1.SelectedCells[0].RowIndex] as Samsung;
                        curr.PhoneModel = textBox1.Text;
                        curr.Restored = checkBoxRestored.Checked;
                        Models[dataGridView1.SelectedCells[0].RowIndex] = curr;
                    }
                    else if (Models[dataGridView1.SelectedCells[0].RowIndex] is Apple)
                    {
                        comboBoxCompany.SelectedIndex = 2;
                        Apple curr = Models[dataGridView1.SelectedCells[0].RowIndex] as Apple;
                        curr.PhoneModel = textBox1.Text;
                        curr.Restored = checkBoxRestored.Checked;
                        Models[dataGridView1.SelectedCells[0].RowIndex] = curr;
                    }
                    else if (Models[dataGridView1.SelectedCells[0].RowIndex] is Xiaomi)
                    {
                        comboBoxCompany.SelectedIndex = 3;
                        Xiaomi curr = Models[dataGridView1.SelectedCells[0].RowIndex] as Xiaomi;
                        curr.PhoneModel = textBox1.Text;
                        Models[dataGridView1.SelectedCells[0].RowIndex] = curr;
                    }
                    else if (Models[dataGridView1.SelectedCells[0].RowIndex] is Huawei)
                    {
                        comboBoxCompany.SelectedIndex = 4;
                        Huawei curr = Models[dataGridView1.SelectedCells[0].RowIndex] as Huawei;
                        curr.PhoneModel = textBox1.Text;
                        Models[dataGridView1.SelectedCells[0].RowIndex] = curr;
                    }
                    dataGridAndAllListsUpdate();
                    ClearTextBoxes();
                }
                else
                {
                    MessageBox.Show("Заполните все поля!");
                }
            }
            catch
            {
                MessageBox.Show("Выберите модель!");
            }
        }

        private void buttonSerialize_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;

            ChooseYourFighter(filename, true);
        }

        private void buttonDeserialize_Click(object sender, EventArgs e)
        {
            Models.Clear();

            string FileName;
            string FileExtension;
            string FileToDeserialize = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog1.FileName;
                FileExtension = Path.GetExtension(FileName);
            }
            else
                return;


            if (FileExtension == ".zip")
            {
                string DllName = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "ZipArchive.dll");
                if (!File.Exists(DllName))
                {
                    Console.Write("Плагин " + DllName + " не найден.");
                    return;
                }

                Assembly AboutAssembly = Assembly.LoadFrom(DllName);

                foreach (Type t in AboutAssembly.GetExportedTypes())
                {
                    if (t.IsClass && typeof(IZip).IsAssignableFrom(t))
                    {
                        IZip about = (IZip)Activator.CreateInstance(t);
                        FileToDeserialize = about.UnZip(FileName, Path.GetFileNameWithoutExtension(FileName));
                        break;
                    }
                }
            }
            else if (FileExtension == ".gz")
            {
                string DllName = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "GzArchive.dll");
                if (!File.Exists(DllName))
                {
                    Console.Write("Плагин " + DllName + " не найден.");
                    return;
                }
                Assembly AboutAssembly = Assembly.LoadFrom(DllName);

                foreach (Type t in AboutAssembly.GetExportedTypes())
                {
                    if (t.IsClass && typeof(IZip).IsAssignableFrom(t))
                    {
                        IZip about = (IZip)Activator.CreateInstance(t);
                        FileToDeserialize = about.UnZip(FileName, Path.GetFileNameWithoutExtension(FileName));
                        break;
                    }
                }
            }
            if (FileExtension == ".bz2")
            {

                string DllName = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "Bz2Archive.dll");
                if (!File.Exists(DllName))
                {
                    Console.Write("Плагин " + DllName + " не найден.");
                    return;
                }
                Assembly AboutAssembly = Assembly.LoadFrom(DllName);

                foreach (Type t in AboutAssembly.GetExportedTypes())
                {
                    if (t.IsClass && typeof(IZip).IsAssignableFrom(t))
                    {
                        IZip about = (IZip)Activator.CreateInstance(t);
                        FileToDeserialize = about.UnZip(FileName, Path.GetFileNameWithoutExtension(FileName));
                        break;
                    }
                }
            }

            if (FileToDeserialize == "")
                ChooseYourFighter(FileName, false);
            else
            {
                ChooseYourFighter(FileToDeserialize, false);

            }


            dataGridAndAllListsUpdate();
        }


        private void ChooseYourFighter(string s, bool saving)
        {
            if (saving)
            {
                if (s.IndexOf(".dat") > 0)
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream fs = new FileStream(s, FileMode.OpenOrCreate))
                    {
                        formatter.Serialize(fs, Models);
                    }
                    if (ArchiveTypeCmBx.Text != "")
                        SetZip(s);
                    MessageBox.Show("Успешно!");
                }
                else if (s.IndexOf(".json") > 0)
                {
                    DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Phones>),
                        new Type[] { typeof(Apple), typeof(Samsung), typeof(Xiaomi), typeof(Huawei) });
                    using (FileStream fs = new FileStream(s, FileMode.OpenOrCreate))
                    {
                        jsonFormatter.WriteObject(fs, Models);
                    }
                    if (ArchiveTypeCmBx.Text != "")
                        SetZip(s);
                    MessageBox.Show("Успешно!");
                }
                else if (s.IndexOf(".txt") > 0)
                {
                    string text = "";
                    for (int i = 0; i < Models.Count; i++)
                    {

                        if (Models[i] is Apple)
                        {
                            Apple curr = Models[i] as Apple;
                            text += $"'Apple'|'{curr.Name}'|'{curr.RepairStartDate}'|'{curr.Number}'|'{curr.EstimatedCost}'|'{curr.Address.City}'|'" +
                                $"{curr.Address.Street}'|'{curr.Address.Building}'|'{curr.PhoneModel}'|'{curr.Restored}'\r\n";
                        }
                        else if (Models[i] is Samsung)
                        {
                            Samsung curr = Models[i] as Samsung;
                            text += $"'Samsung'|'{curr.Name}'|'{curr.RepairStartDate}'|'{curr.Number}'|'{curr.EstimatedCost}'|'{curr.Address.City}'|'" +
                                $"{curr.Address.Street}'|'{curr.Address.Building}'|'{curr.PhoneModel}'|'{curr.Restored}'\r\n";
                        }
                        else if (Models[i] is Xiaomi)
                        {
                            Xiaomi curr = Models[i] as Xiaomi;
                            text += $"'Xiaomi'|'{curr.Name}'|'{curr.RepairStartDate}'|'{curr.Number}'|'{curr.EstimatedCost}'|'{curr.Address.City}'|'" +
                                $"{curr.Address.Street}'|'{curr.Address.Building}'|'{curr.PhoneModel}'\r\n";
                        }
                        else if (Models[i] is Huawei)
                        {
                            Huawei curr = Models[i] as Huawei;
                            text += $"'Huawei'|'{curr.Name}'|'{curr.RepairStartDate}'|'{curr.Number}'|'{curr.EstimatedCost}'|'{curr.Address.City}'|'" +
                                $"{curr.Address.Street}'|'{curr.Address.Building}'|'{curr.PhoneModel}'\r\n";
                        }
                        else
                        {
                            Phones curr = Models[i] as Phones;
                            text += $"'Не уточнено'|'{curr.Name}'|'{curr.RepairStartDate}'|'{curr.Number}'|'{curr.EstimatedCost}'|'{curr.Address.City}'|'" +
                                $"{curr.Address.Street}'|'{curr.Address.Building}'\r\n";
                        }
                    }
                    using (FileStream fs = new FileStream(s, FileMode.OpenOrCreate))
                    {
                        byte[] array = Encoding.Default.GetBytes(text);
                        fs.Write(array, 0, array.Length);
                    }
                    if (ArchiveTypeCmBx.Text != "")
                        SetZip(s);
                    MessageBox.Show("Успешно!");
                }
                else
                    MessageBox.Show("Что-то пошло не так!");
            }
            else
            {
                if (s.IndexOf(".dat") > 0)
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream fs = new FileStream(s, FileMode.OpenOrCreate))
                    {
                        Models = (List<Phones>)formatter.Deserialize(fs);
                    }
                    MessageBox.Show("Успешно!");
                }
                else if (s.IndexOf(".json") > 0)
                {
                    DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Phones>),
                        new Type[] { typeof(Apple), typeof(Samsung), typeof(Xiaomi), typeof(Huawei) });
                    using (FileStream fs = new FileStream(s, FileMode.OpenOrCreate))
                    {
                        Models = (List<Phones>)jsonFormatter.ReadObject(fs);
                    }
                    MessageBox.Show("Успешно!");
                }
                else if (s.IndexOf(".txt") > 0)
                {
                    using (StreamReader sr = new StreamReader(s, System.Text.Encoding.Default))
                    {
                        while (!sr.EndOfStream)
                        {
                            string[] line = sr.ReadLine().Split('|');
                            string clName = line[0].Substring(1, line[0].Length - 2);
                            string name = line[1].Substring(1, line[1].Length - 2);
                            DateTime repairStartDate = Convert.ToDateTime(line[2].Substring(1, line[2].Length - 2));
                            string number = line[3].Substring(1, line[3].Length - 2);
                            int estimatedCost = Convert.ToInt32(line[4].Substring(1, line[4].Length - 2));
                            string city = line[5].Substring(1, line[5].Length - 2);
                            string street = line[6].Substring(1, line[6].Length - 2);
                            int building = Convert.ToInt32(line[7].Substring(1, line[7].Length - 2));
                            string secondparam = "";
                            if (clName != "Не уточнено")
                                secondparam = line[8].Substring(1, line[8].Length - 2);
                            bool restored = false;
                            if (clName == "Apple")
                            {
                                restored = Convert.ToBoolean(line[9].Substring(1, line[9].Length - 2));
                            }

                            if (clName == "Samsung")
                            {
                                restored = Convert.ToBoolean(line[9].Substring(1, line[9].Length - 2));
                            }

                            Address currAddr = new Address(city, street, building);
                            Phones phone1 = getModelsTypeByString(clName, name, repairStartDate, number, currAddr, estimatedCost, secondparam, restored);
                            Models.Add(phone1);
                        }
                    }
                    MessageBox.Show("Успешно!");
                }
                else
                    MessageBox.Show("Что-то пошло не так!");
            }
        }

        private void ArchiveTypeCmBx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Zip(string source, string target, string pluginName)
        {
            string DllName = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), pluginName);
            if (!File.Exists(DllName))
            {
                Console.Write("Плагин " + DllName + " не найден.");
                return;
            }

            Assembly AboutAssembly = Assembly.LoadFrom(DllName);

            foreach (Type t in AboutAssembly.GetExportedTypes())
            {
                if (t.IsClass && typeof(IZip).IsAssignableFrom(t))
                {
                    IZip about = (IZip)Activator.CreateInstance(t);
                    about.Zip(source, target);
                    break;
                }
            }
        }

        private void SetZip(string FileToZip)
        {
            if (ArchiveTypeCmBx.Text == "Zip")
            {
                Zip(FileToZip, FileToZip + ".zip", "ZipArchive.dll");
            }
            else if (ArchiveTypeCmBx.Text == "GZip")
            {
                Zip(FileToZip, FileToZip + ".gz", "GzArchive.dll");
            }
            if (ArchiveTypeCmBx.Text == "BZip2")
            {
                Zip(FileToZip, FileToZip + ".bz2", "Bz2Archive.dll");
            }
            File.Delete(FileToZip);
        }
    }
}