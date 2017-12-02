namespace expertsChoiceManage
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lab_type = new System.Windows.Forms.Label();
            this.lab_people = new System.Windows.Forms.Label();
            this.button_Ok = new System.Windows.Forms.Button();
            this.button_ShowAll = new System.Windows.Forms.Button();
            this.textBox_People = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBoxExperot = new System.Windows.Forms.GroupBox();
            this.buttonNewNewOk = new System.Windows.Forms.Button();
            this.comboBoxNewType = new System.Windows.Forms.ComboBox();
            this.textBoxNewTel = new System.Windows.Forms.TextBox();
            this.textBoxNewWorkPlace = new System.Windows.Forms.TextBox();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.labelNewType = new System.Windows.Forms.Label();
            this.labelNewTel = new System.Windows.Forms.Label();
            this.labelNewWorkPlace = new System.Windows.Forms.Label();
            this.labelNewName = new System.Windows.Forms.Label();
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.buttonNewOk = new System.Windows.Forms.Button();
            this.textBoxNewProje = new System.Windows.Forms.TextBox();
            this.label_NewProject = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBoxExperot.SuspendLayout();
            this.groupBoxType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lab_type
            // 
            this.lab_type.AutoSize = true;
            this.lab_type.Location = new System.Drawing.Point(28, 49);
            this.lab_type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_type.Name = "lab_type";
            this.lab_type.Size = new System.Drawing.Size(67, 15);
            this.lab_type.TabIndex = 0;
            this.lab_type.Text = "项目类型";
            // 
            // lab_people
            // 
            this.lab_people.AutoSize = true;
            this.lab_people.Location = new System.Drawing.Point(363, 49);
            this.lab_people.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_people.Name = "lab_people";
            this.lab_people.Size = new System.Drawing.Size(37, 15);
            this.lab_people.TabIndex = 1;
            this.lab_people.Text = "人数";
            // 
            // button_Ok
            // 
            this.button_Ok.Location = new System.Drawing.Point(572, 39);
            this.button_Ok.Margin = new System.Windows.Forms.Padding(4);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(100, 29);
            this.button_Ok.TabIndex = 2;
            this.button_Ok.Text = "确定";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // button_ShowAll
            // 
            this.button_ShowAll.Location = new System.Drawing.Point(690, 39);
            this.button_ShowAll.Margin = new System.Windows.Forms.Padding(4);
            this.button_ShowAll.Name = "button_ShowAll";
            this.button_ShowAll.Size = new System.Drawing.Size(100, 29);
            this.button_ShowAll.TabIndex = 3;
            this.button_ShowAll.Text = "显示全部";
            this.button_ShowAll.UseVisualStyleBackColor = true;
            this.button_ShowAll.Click += new System.EventHandler(this.button_ShowAll_Click);
            // 
            // textBox_People
            // 
            this.textBox_People.Location = new System.Drawing.Point(408, 43);
            this.textBox_People.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_People.Name = "textBox_People";
            this.textBox_People.Size = new System.Drawing.Size(100, 25);
            this.textBox_People.TabIndex = 4;
            // 
            // dataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Location = new System.Drawing.Point(31, 105);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(759, 346);
            this.dataGridView.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(961, 484);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox_type);
            this.tabPage1.Controls.Add(this.lab_type);
            this.tabPage1.Controls.Add(this.dataGridView);
            this.tabPage1.Controls.Add(this.lab_people);
            this.tabPage1.Controls.Add(this.button_ShowAll);
            this.tabPage1.Controls.Add(this.textBox_People);
            this.tabPage1.Controls.Add(this.button_Ok);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(953, 455);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "抽取专家";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox_type
            // 
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Location = new System.Drawing.Point(103, 46);
            this.comboBox_type.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(120, 23);
            this.comboBox_type.TabIndex = 6;
            this.comboBox_type.SelectedIndexChanged += new System.EventHandler(this.comboBox_type_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBoxExperot);
            this.tabPage2.Controls.Add(this.groupBoxType);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(953, 455);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "数据维护";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBoxExperot
            // 
            this.groupBoxExperot.Controls.Add(this.buttonNewNewOk);
            this.groupBoxExperot.Controls.Add(this.comboBoxNewType);
            this.groupBoxExperot.Controls.Add(this.textBoxNewTel);
            this.groupBoxExperot.Controls.Add(this.textBoxNewWorkPlace);
            this.groupBoxExperot.Controls.Add(this.textBoxNewName);
            this.groupBoxExperot.Controls.Add(this.labelNewType);
            this.groupBoxExperot.Controls.Add(this.labelNewTel);
            this.groupBoxExperot.Controls.Add(this.labelNewWorkPlace);
            this.groupBoxExperot.Controls.Add(this.labelNewName);
            this.groupBoxExperot.Location = new System.Drawing.Point(45, 230);
            this.groupBoxExperot.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxExperot.Name = "groupBoxExperot";
            this.groupBoxExperot.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxExperot.Size = new System.Drawing.Size(684, 155);
            this.groupBoxExperot.TabIndex = 1;
            this.groupBoxExperot.TabStop = false;
            this.groupBoxExperot.Text = "添加专家记录";
            // 
            // buttonNewNewOk
            // 
            this.buttonNewNewOk.Location = new System.Drawing.Point(567, 40);
            this.buttonNewNewOk.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNewNewOk.Name = "buttonNewNewOk";
            this.buttonNewNewOk.Size = new System.Drawing.Size(100, 29);
            this.buttonNewNewOk.TabIndex = 9;
            this.buttonNewNewOk.Text = "确定";
            this.buttonNewNewOk.UseVisualStyleBackColor = true;
            this.buttonNewNewOk.Click += new System.EventHandler(this.buttonNewNewOk_Click);
            // 
            // comboBoxNewType
            // 
            this.comboBoxNewType.FormattingEnabled = true;
            this.comboBoxNewType.Location = new System.Drawing.Point(409, 105);
            this.comboBoxNewType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxNewType.Name = "comboBoxNewType";
            this.comboBoxNewType.Size = new System.Drawing.Size(160, 23);
            this.comboBoxNewType.TabIndex = 8;
            // 
            // textBoxNewTel
            // 
            this.textBoxNewTel.Location = new System.Drawing.Point(101, 98);
            this.textBoxNewTel.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNewTel.Name = "textBoxNewTel";
            this.textBoxNewTel.Size = new System.Drawing.Size(131, 25);
            this.textBoxNewTel.TabIndex = 7;
            // 
            // textBoxNewWorkPlace
            // 
            this.textBoxNewWorkPlace.Location = new System.Drawing.Point(425, 49);
            this.textBoxNewWorkPlace.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNewWorkPlace.Name = "textBoxNewWorkPlace";
            this.textBoxNewWorkPlace.Size = new System.Drawing.Size(132, 25);
            this.textBoxNewWorkPlace.TabIndex = 6;
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.Location = new System.Drawing.Point(101, 49);
            this.textBoxNewName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(132, 25);
            this.textBoxNewName.TabIndex = 5;
            // 
            // labelNewType
            // 
            this.labelNewType.AutoSize = true;
            this.labelNewType.Location = new System.Drawing.Point(308, 109);
            this.labelNewType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNewType.Name = "labelNewType";
            this.labelNewType.Size = new System.Drawing.Size(67, 15);
            this.labelNewType.TabIndex = 4;
            this.labelNewType.Text = "所属类型";
            // 
            // labelNewTel
            // 
            this.labelNewTel.AutoSize = true;
            this.labelNewTel.Location = new System.Drawing.Point(20, 109);
            this.labelNewTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNewTel.Name = "labelNewTel";
            this.labelNewTel.Size = new System.Drawing.Size(37, 15);
            this.labelNewTel.TabIndex = 3;
            this.labelNewTel.Text = "电话";
            // 
            // labelNewWorkPlace
            // 
            this.labelNewWorkPlace.AutoSize = true;
            this.labelNewWorkPlace.Location = new System.Drawing.Point(308, 46);
            this.labelNewWorkPlace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNewWorkPlace.Name = "labelNewWorkPlace";
            this.labelNewWorkPlace.Size = new System.Drawing.Size(37, 15);
            this.labelNewWorkPlace.TabIndex = 2;
            this.labelNewWorkPlace.Text = "单位";
            // 
            // labelNewName
            // 
            this.labelNewName.AutoSize = true;
            this.labelNewName.Location = new System.Drawing.Point(20, 46);
            this.labelNewName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNewName.Name = "labelNewName";
            this.labelNewName.Size = new System.Drawing.Size(37, 15);
            this.labelNewName.TabIndex = 1;
            this.labelNewName.Text = "姓名";
            // 
            // groupBoxType
            // 
            this.groupBoxType.Controls.Add(this.buttonNewOk);
            this.groupBoxType.Controls.Add(this.textBoxNewProje);
            this.groupBoxType.Controls.Add(this.label_NewProject);
            this.groupBoxType.Location = new System.Drawing.Point(44, 44);
            this.groupBoxType.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxType.Size = new System.Drawing.Size(676, 150);
            this.groupBoxType.TabIndex = 0;
            this.groupBoxType.TabStop = false;
            this.groupBoxType.Text = "添加项目类型";
            // 
            // buttonNewOk
            // 
            this.buttonNewOk.Location = new System.Drawing.Point(380, 54);
            this.buttonNewOk.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNewOk.Name = "buttonNewOk";
            this.buttonNewOk.Size = new System.Drawing.Size(100, 29);
            this.buttonNewOk.TabIndex = 2;
            this.buttonNewOk.Text = "确定";
            this.buttonNewOk.UseVisualStyleBackColor = true;
            this.buttonNewOk.Click += new System.EventHandler(this.buttonNewOk_Click);
            // 
            // textBoxNewProje
            // 
            this.textBoxNewProje.Location = new System.Drawing.Point(180, 56);
            this.textBoxNewProje.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNewProje.Name = "textBoxNewProje";
            this.textBoxNewProje.Size = new System.Drawing.Size(132, 25);
            this.textBoxNewProje.TabIndex = 1;
            // 
            // label_NewProject
            // 
            this.label_NewProject.AutoSize = true;
            this.label_NewProject.Location = new System.Drawing.Point(48, 60);
            this.label_NewProject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_NewProject.Name = "label_NewProject";
            this.label_NewProject.Size = new System.Drawing.Size(112, 15);
            this.label_NewProject.TabIndex = 0;
            this.label_NewProject.Text = "新项目类型名称";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 500);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "专家库管理程序";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBoxExperot.ResumeLayout(false);
            this.groupBoxExperot.PerformLayout();
            this.groupBoxType.ResumeLayout(false);
            this.groupBoxType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lab_type;
        private System.Windows.Forms.Label lab_people;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.Button button_ShowAll;
        private System.Windows.Forms.TextBox textBox_People;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBoxExperot;
        private System.Windows.Forms.Button buttonNewNewOk;
        private System.Windows.Forms.ComboBox comboBoxNewType;
        private System.Windows.Forms.TextBox textBoxNewTel;
        private System.Windows.Forms.TextBox textBoxNewWorkPlace;
        private System.Windows.Forms.TextBox textBoxNewName;
        private System.Windows.Forms.Label labelNewType;
        private System.Windows.Forms.Label labelNewTel;
        private System.Windows.Forms.Label labelNewWorkPlace;
        private System.Windows.Forms.Label labelNewName;
        private System.Windows.Forms.GroupBox groupBoxType;
        private System.Windows.Forms.Button buttonNewOk;
        private System.Windows.Forms.TextBox textBoxNewProje;
        private System.Windows.Forms.Label label_NewProject;
    }
}

