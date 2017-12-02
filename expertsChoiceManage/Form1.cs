using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace expertsChoiceManage
{
    public partial class Form1 : Form
    {
        List<Expert> ExpertInfo=new List<Expert>();

        public class Expert
        {
            private string _name;
            private string _unit;
            private string _tel;

            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }

            public string Unit { get; set; }
            public string Tel  { get; set; }
          
        }

        void FillType()
        {
            comboBox_type.Items.Clear();
            comboBoxNewType.Items.Clear();

            StreamReader sr = new StreamReader("type.txt", Encoding.Default);

            try
            {
                while(!sr.EndOfStream)
                {
                    string Items = sr.ReadLine();
                    if(Items!="")
                    {
                        comboBox_type.Items.Add(Items);
                        comboBoxNewType.Items.Add(Items);
                    }
                }
                comboBox_type.Text = comboBox_type.Items[0].ToString();
                comboBoxNewType.Text = comboBox_type.Items[0].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "出错", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                sr.Close();
            }
        }

        void GetData()
        {
            ExpertInfo.Clear();
            if(!File.Exists(comboBox_type.Text+".txt"))
            {
                MessageBox.Show("尚未建立该类型的专家库", "出错", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            StreamReader sr = new StreamReader(comboBox_type.Text+".txt",Encoding.Default);
            try
            {
                while(!sr.EndOfStream)
                {
                    Expert exp = new Expert();
                    exp.Name = sr.ReadLine();
                    if(exp.Name!="")
                    {
                        exp.Unit = sr.ReadLine();
                        exp.Tel = sr.ReadLine();
                    }
                    ExpertInfo.Add(exp);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "出错", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                sr.Close();
            }
        }

        void FillData()
        {
            if(dataGridView.ColumnCount==0)
            {
                DataGridViewTextBoxColumn coll = new DataGridViewTextBoxColumn();
                coll.Width = 100;
                coll.HeaderText = "姓名";
                coll.DataPropertyName = "Name";

                DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
                col2.Width = 187;
                col2.HeaderText = "工作单位";
                col2.DataPropertyName = "Unit";

                DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
                col3.Width = 100;
                col3.HeaderText = "联系电话";
                col3.DataPropertyName = "Tel";

                dataGridView.Columns.Add(coll);
                dataGridView.Columns.Add(col2);
                dataGridView.Columns.Add(col3);
            }
            dataGridView.DataSource = ExpertInfo;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillType();
            GetData();
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            Random rd = new Random();
            GetData();
            int Num;
            try
            {
                Num = int.Parse(textBox_People.Text);
            }
            catch(FormatException)
            {
                MessageBox.Show("输入数据格式有错误", "出错", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(Num>ExpertInfo.Count)
            {
                MessageBox.Show("目前专家库仅有" + ExpertInfo.Count.ToString() + " 位专家", "出错", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int RemoveRows = ExpertInfo.Count - int.Parse(textBox_People.Text);
            for(int i=0;i<RemoveRows;i++)
            {
                ExpertInfo.RemoveAt(rd.Next(0, ExpertInfo.Count));
            }
            FillData();
        }

        private void button_ShowAll_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            GetData();
            FillData();
        }

        private void buttonNewOk_Click(object sender, EventArgs e)
        {
            if(textBoxNewProje.Text=="")
            {
                MessageBox.Show("项目类型名称不能为空", "出错", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            for(int i=0;i<comboBoxNewType.Items.Count;i++)
            {
                if(comboBoxNewType.Items[i].ToString()==textBoxNewProje.Text)
                {
                    MessageBox.Show("项目已存在", "出错", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            StreamWriter sw=new StreamWriter("type.txt", true, Encoding.Default);
            try
            {
                sw.WriteLine(textBoxNewProje.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "出错", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            finally
            {
                sw.Close();
            }
            MessageBox.Show("数据添加成功", "完成", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            textBoxNewProje.Text = "";
            textBoxNewProje.Focus();
            FillType();
        }

        private void buttonNewNewOk_Click(object sender, EventArgs e)
        {
            if(textBoxNewName.Text==""||textBoxNewTel.Text==""||textBoxNewWorkPlace.Text=="")
            {
                MessageBox.Show("请输入完整数据", "出错", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(File.Exists(comboBoxNewType.Text+".txt"))
            {
                StreamReader sr = new StreamReader(comboBoxNewType.Text + ".txt", Encoding.Default);
                try
                {
                    while(!sr.EndOfStream)
                    {
                        string ExpName = sr.ReadLine();
                        string ExpUnit = sr.ReadLine();
                        string ExpTel = sr.ReadLine();
                        if(ExpName==textBoxNewName.Text&&ExpUnit==textBoxNewWorkPlace.Text&&ExpTel==textBoxNewTel.Text)
                        {
                            MessageBox.Show("要添加的专家已存在", "出错", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "出错", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                finally
                {
                    sr.Close();
                }
            }
            StreamWriter sw = new StreamWriter(comboBoxNewType.Text + ".txt", true, Encoding.Default);
            try
            {
                sw.WriteLine(textBoxNewName.Text);
                sw.WriteLine(textBoxNewWorkPlace.Text);
                sw.WriteLine(textBoxNewTel.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "出错", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            finally
            {
                sw.Close();
            }
            MessageBox.Show("数据添加成功", "完成", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            textBoxNewName.Text = "";
            textBoxNewWorkPlace.Text = "";
            textBoxNewTel.Text = "";
            textBoxNewName.Focus();
        }

        private void comboBox_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            ComboBox combo = (ComboBox)sender;
            if (combo.Name != "comboBoxNewType")
            {
                GetData();
            }
            FillData();
        }
    }
}
