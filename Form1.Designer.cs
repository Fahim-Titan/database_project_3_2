namespace database_project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label doctor_IdLabel;
            System.Windows.Forms.Label doctor_NameLabel;
            System.Windows.Forms.Label doctor_DeptLabel;
            System.Windows.Forms.Label doctor_IdLabel1;
            System.Windows.Forms.Label patient_IdLabel;
            System.Windows.Forms.Label room_IdLabel;
            System.Windows.Forms.Label patient_IdLabel1;
            System.Windows.Forms.Label patient_IdLabel2;
            System.Windows.Forms.Label date_Bill_PaidLabel;
            System.Windows.Forms.Label total_AmountLabel;
            System.Windows.Forms.Label patient_IdLabel3;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label dOBLabel;
            System.Windows.Forms.Label f_NameLabel;
            System.Windows.Forms.Label l_NameLabel;
            System.Windows.Forms.Label heightLabel;
            System.Windows.Forms.Label weightLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label h_PhoneLabel;
            System.Windows.Forms.Label label9;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_Dob = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATIENTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new database_project.Database1DataSet();
            this.txtH_phone = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtl_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtf_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_ref = new System.Windows.Forms.Button();
            this.btn_doctor_add = new System.Windows.Forms.Button();
            this.doctor_IdTextBox = new System.Windows.Forms.TextBox();
            this.dOCTORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctor_NameTextBox = new System.Windows.Forms.TextBox();
            this.doctor_DeptTextBox = new System.Windows.Forms.TextBox();
            this.dOCTORDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_ref_serial = new System.Windows.Forms.Button();
            this.btn_serial = new System.Windows.Forms.Button();
            this.sERIALDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sERIALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctor_IdTextBox1 = new System.Windows.Forms.TextBox();
            this.patient_IdTextBox = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.rOOMDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOOMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.room_IdTextBox = new System.Windows.Forms.TextBox();
            this.patient_IdTextBox1 = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.pay_btn = new System.Windows.Forms.Button();
            this.pay_txt_pat_id = new System.Windows.Forms.TextBox();
            this.pAYMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.date_Bill_PaidDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pay_txt_total_amount = new System.Windows.Forms.TextBox();
            this.pAYMENTDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.h_PhoneTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.l_NameTextBox = new System.Windows.Forms.TextBox();
            this.f_NameTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.patient_IdTextBox2 = new System.Windows.Forms.TextBox();
            this.update_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_pat_delete = new System.Windows.Forms.TextBox();
            this.dOBDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pATIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dOCTORTableAdapter = new database_project.Database1DataSetTableAdapters.DOCTORTableAdapter();
            this.pATIENTTableAdapter = new database_project.Database1DataSetTableAdapters.PATIENTTableAdapter();
            this.tableAdapterManager = new database_project.Database1DataSetTableAdapters.TableAdapterManager();
            this.dOCTORBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sERIALTableAdapter = new database_project.Database1DataSetTableAdapters.SERIALTableAdapter();
            this.rOOMTableAdapter = new database_project.Database1DataSetTableAdapters.ROOMTableAdapter();
            this.pAYMENTTableAdapter = new database_project.Database1DataSetTableAdapters.PAYMENTTableAdapter();
            doctor_IdLabel = new System.Windows.Forms.Label();
            doctor_NameLabel = new System.Windows.Forms.Label();
            doctor_DeptLabel = new System.Windows.Forms.Label();
            doctor_IdLabel1 = new System.Windows.Forms.Label();
            patient_IdLabel = new System.Windows.Forms.Label();
            room_IdLabel = new System.Windows.Forms.Label();
            patient_IdLabel1 = new System.Windows.Forms.Label();
            patient_IdLabel2 = new System.Windows.Forms.Label();
            date_Bill_PaidLabel = new System.Windows.Forms.Label();
            total_AmountLabel = new System.Windows.Forms.Label();
            patient_IdLabel3 = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            dOBLabel = new System.Windows.Forms.Label();
            f_NameLabel = new System.Windows.Forms.Label();
            l_NameLabel = new System.Windows.Forms.Label();
            heightLabel = new System.Windows.Forms.Label();
            weightLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            h_PhoneLabel = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORDataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sERIALDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERIALBindingSource)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rOOMDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOOMBindingSource)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pAYMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAYMENTDataGridView)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // doctor_IdLabel
            // 
            doctor_IdLabel.AutoSize = true;
            doctor_IdLabel.Location = new System.Drawing.Point(24, 30);
            doctor_IdLabel.Name = "doctor_IdLabel";
            doctor_IdLabel.Size = new System.Drawing.Size(54, 13);
            doctor_IdLabel.TabIndex = 5;
            doctor_IdLabel.Text = "Doctor Id:";
            // 
            // doctor_NameLabel
            // 
            doctor_NameLabel.AutoSize = true;
            doctor_NameLabel.Location = new System.Drawing.Point(24, 56);
            doctor_NameLabel.Name = "doctor_NameLabel";
            doctor_NameLabel.Size = new System.Drawing.Size(73, 13);
            doctor_NameLabel.TabIndex = 7;
            doctor_NameLabel.Text = "Doctor Name:";
            // 
            // doctor_DeptLabel
            // 
            doctor_DeptLabel.AutoSize = true;
            doctor_DeptLabel.Location = new System.Drawing.Point(24, 82);
            doctor_DeptLabel.Name = "doctor_DeptLabel";
            doctor_DeptLabel.Size = new System.Drawing.Size(68, 13);
            doctor_DeptLabel.TabIndex = 9;
            doctor_DeptLabel.Text = "Doctor Dept:";
            // 
            // doctor_IdLabel1
            // 
            doctor_IdLabel1.AutoSize = true;
            doctor_IdLabel1.Location = new System.Drawing.Point(34, 79);
            doctor_IdLabel1.Name = "doctor_IdLabel1";
            doctor_IdLabel1.Size = new System.Drawing.Size(54, 13);
            doctor_IdLabel1.TabIndex = 2;
            doctor_IdLabel1.Text = "Doctor Id:";
            // 
            // patient_IdLabel
            // 
            patient_IdLabel.AutoSize = true;
            patient_IdLabel.Location = new System.Drawing.Point(34, 105);
            patient_IdLabel.Name = "patient_IdLabel";
            patient_IdLabel.Size = new System.Drawing.Size(55, 13);
            patient_IdLabel.TabIndex = 4;
            patient_IdLabel.Text = "Patient Id:";
            // 
            // room_IdLabel
            // 
            room_IdLabel.AutoSize = true;
            room_IdLabel.Location = new System.Drawing.Point(36, 55);
            room_IdLabel.Name = "room_IdLabel";
            room_IdLabel.Size = new System.Drawing.Size(50, 13);
            room_IdLabel.TabIndex = 0;
            room_IdLabel.Text = "Room Id:";
            // 
            // patient_IdLabel1
            // 
            patient_IdLabel1.AutoSize = true;
            patient_IdLabel1.Location = new System.Drawing.Point(36, 81);
            patient_IdLabel1.Name = "patient_IdLabel1";
            patient_IdLabel1.Size = new System.Drawing.Size(55, 13);
            patient_IdLabel1.TabIndex = 2;
            patient_IdLabel1.Text = "Patient Id:";
            // 
            // patient_IdLabel2
            // 
            patient_IdLabel2.AutoSize = true;
            patient_IdLabel2.Location = new System.Drawing.Point(135, 26);
            patient_IdLabel2.Name = "patient_IdLabel2";
            patient_IdLabel2.Size = new System.Drawing.Size(55, 13);
            patient_IdLabel2.TabIndex = 3;
            patient_IdLabel2.Text = "Patient Id:";
            // 
            // date_Bill_PaidLabel
            // 
            date_Bill_PaidLabel.AutoSize = true;
            date_Bill_PaidLabel.Location = new System.Drawing.Point(135, 53);
            date_Bill_PaidLabel.Name = "date_Bill_PaidLabel";
            date_Bill_PaidLabel.Size = new System.Drawing.Size(73, 13);
            date_Bill_PaidLabel.TabIndex = 5;
            date_Bill_PaidLabel.Text = "Date Bill Paid:";
            // 
            // total_AmountLabel
            // 
            total_AmountLabel.AutoSize = true;
            total_AmountLabel.Location = new System.Drawing.Point(135, 78);
            total_AmountLabel.Name = "total_AmountLabel";
            total_AmountLabel.Size = new System.Drawing.Size(73, 13);
            total_AmountLabel.TabIndex = 7;
            total_AmountLabel.Text = "Total Amount:";
            // 
            // patient_IdLabel3
            // 
            patient_IdLabel3.AutoSize = true;
            patient_IdLabel3.Location = new System.Drawing.Point(19, 59);
            patient_IdLabel3.Name = "patient_IdLabel3";
            patient_IdLabel3.Size = new System.Drawing.Size(55, 13);
            patient_IdLabel3.TabIndex = 0;
            patient_IdLabel3.Text = "Patient Id:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(19, 85);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(45, 13);
            genderLabel.TabIndex = 2;
            genderLabel.Text = "Gender:";
            // 
            // dOBLabel
            // 
            dOBLabel.AutoSize = true;
            dOBLabel.Location = new System.Drawing.Point(19, 112);
            dOBLabel.Name = "dOBLabel";
            dOBLabel.Size = new System.Drawing.Size(33, 13);
            dOBLabel.TabIndex = 4;
            dOBLabel.Text = "DOB:";
            // 
            // f_NameLabel
            // 
            f_NameLabel.AutoSize = true;
            f_NameLabel.Location = new System.Drawing.Point(19, 137);
            f_NameLabel.Name = "f_NameLabel";
            f_NameLabel.Size = new System.Drawing.Size(47, 13);
            f_NameLabel.TabIndex = 6;
            f_NameLabel.Text = "F Name:";
            // 
            // l_NameLabel
            // 
            l_NameLabel.AutoSize = true;
            l_NameLabel.Location = new System.Drawing.Point(19, 163);
            l_NameLabel.Name = "l_NameLabel";
            l_NameLabel.Size = new System.Drawing.Size(47, 13);
            l_NameLabel.TabIndex = 8;
            l_NameLabel.Text = "L Name:";
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Location = new System.Drawing.Point(19, 189);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new System.Drawing.Size(41, 13);
            heightLabel.TabIndex = 10;
            heightLabel.Text = "Height:";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new System.Drawing.Point(19, 215);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new System.Drawing.Size(44, 13);
            weightLabel.TabIndex = 12;
            weightLabel.Text = "Weight:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(19, 241);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 14;
            phoneLabel.Text = "Phone:";
            // 
            // h_PhoneLabel
            // 
            h_PhoneLabel.AutoSize = true;
            h_PhoneLabel.Location = new System.Drawing.Point(19, 267);
            h_PhoneLabel.Name = "h_PhoneLabel";
            h_PhoneLabel.Size = new System.Drawing.Size(72, 13);
            h_PhoneLabel.TabIndex = 16;
            h_PhoneLabel.Text = "Home Phone:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(434, 108);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(55, 13);
            label9.TabIndex = 18;
            label9.Text = "Patient Id:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(805, 387);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_Dob);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.btn_reset);
            this.tabPage1.Controls.Add(this.btn_add);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.txtH_phone);
            this.tabPage1.Controls.Add(this.txtPhone);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtWeight);
            this.tabPage1.Controls.Add(this.txtHeight);
            this.tabPage1.Controls.Add(this.txtGender);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtl_name);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtf_name);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(797, 361);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Patient";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_Dob
            // 
            this.txt_Dob.Location = new System.Drawing.Point(102, 244);
            this.txt_Dob.Name = "txt_Dob";
            this.txt_Dob.Size = new System.Drawing.Size(200, 20);
            this.txt_Dob.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "DOB";
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(187, 288);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(100, 37);
            this.btn_reset.TabIndex = 16;
            this.btn_reset.Text = "Refresh";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(65, 288);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 37);
            this.btn_add.TabIndex = 15;
            this.btn_add.Text = "Add Patient";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientIdDataGridViewTextBoxColumn,
            this.fNameDataGridViewTextBoxColumn,
            this.lNameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pATIENTBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(373, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(418, 331);
            this.dataGridView1.TabIndex = 14;
            // 
            // patientIdDataGridViewTextBoxColumn
            // 
            this.patientIdDataGridViewTextBoxColumn.DataPropertyName = "Patient_Id";
            this.patientIdDataGridViewTextBoxColumn.HeaderText = "Patient_Id";
            this.patientIdDataGridViewTextBoxColumn.Name = "patientIdDataGridViewTextBoxColumn";
            this.patientIdDataGridViewTextBoxColumn.Width = 50;
            // 
            // fNameDataGridViewTextBoxColumn
            // 
            this.fNameDataGridViewTextBoxColumn.DataPropertyName = "F_Name";
            this.fNameDataGridViewTextBoxColumn.HeaderText = "F_Name";
            this.fNameDataGridViewTextBoxColumn.Name = "fNameDataGridViewTextBoxColumn";
            // 
            // lNameDataGridViewTextBoxColumn
            // 
            this.lNameDataGridViewTextBoxColumn.DataPropertyName = "L_Name";
            this.lNameDataGridViewTextBoxColumn.HeaderText = "L_Name";
            this.lNameDataGridViewTextBoxColumn.Name = "lNameDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 50;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // pATIENTBindingSource1
            // 
            this.pATIENTBindingSource1.DataMember = "PATIENT";
            this.pATIENTBindingSource1.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtH_phone
            // 
            this.txtH_phone.Location = new System.Drawing.Point(102, 203);
            this.txtH_phone.Name = "txtH_phone";
            this.txtH_phone.Size = new System.Drawing.Size(88, 20);
            this.txtH_phone.TabIndex = 13;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(102, 174);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(88, 20);
            this.txtPhone.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Home Phone";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(102, 146);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(88, 20);
            this.txtWeight.TabIndex = 9;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(102, 118);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(88, 20);
            this.txtHeight.TabIndex = 8;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(102, 86);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(88, 20);
            this.txtGender.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Weight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gender";
            // 
            // txtl_name
            // 
            this.txtl_name.Location = new System.Drawing.Point(102, 53);
            this.txtl_name.Name = "txtl_name";
            this.txtl_name.Size = new System.Drawing.Size(254, 20);
            this.txtl_name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // txtf_name
            // 
            this.txtf_name.Location = new System.Drawing.Point(102, 17);
            this.txtf_name.Name = "txtf_name";
            this.txtf_name.Size = new System.Drawing.Size(254, 20);
            this.txtf_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_ref);
            this.tabPage2.Controls.Add(this.btn_doctor_add);
            this.tabPage2.Controls.Add(doctor_IdLabel);
            this.tabPage2.Controls.Add(this.doctor_IdTextBox);
            this.tabPage2.Controls.Add(doctor_NameLabel);
            this.tabPage2.Controls.Add(this.doctor_NameTextBox);
            this.tabPage2.Controls.Add(doctor_DeptLabel);
            this.tabPage2.Controls.Add(this.doctor_DeptTextBox);
            this.tabPage2.Controls.Add(this.dOCTORDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(797, 361);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Doctor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_ref
            // 
            this.btn_ref.Location = new System.Drawing.Point(128, 185);
            this.btn_ref.Name = "btn_ref";
            this.btn_ref.Size = new System.Drawing.Size(75, 23);
            this.btn_ref.TabIndex = 12;
            this.btn_ref.Text = "Refresh";
            this.btn_ref.UseVisualStyleBackColor = true;
            this.btn_ref.Click += new System.EventHandler(this.btn_ref_Click);
            // 
            // btn_doctor_add
            // 
            this.btn_doctor_add.Location = new System.Drawing.Point(27, 185);
            this.btn_doctor_add.Name = "btn_doctor_add";
            this.btn_doctor_add.Size = new System.Drawing.Size(75, 23);
            this.btn_doctor_add.TabIndex = 11;
            this.btn_doctor_add.Text = "Add Doctor";
            this.btn_doctor_add.UseVisualStyleBackColor = true;
            this.btn_doctor_add.Click += new System.EventHandler(this.btn_doctor_add_Click);
            // 
            // doctor_IdTextBox
            // 
            this.doctor_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dOCTORBindingSource, "Doctor_Id", true));
            this.doctor_IdTextBox.Location = new System.Drawing.Point(103, 27);
            this.doctor_IdTextBox.Name = "doctor_IdTextBox";
            this.doctor_IdTextBox.Size = new System.Drawing.Size(100, 20);
            this.doctor_IdTextBox.TabIndex = 6;
            // 
            // dOCTORBindingSource
            // 
            this.dOCTORBindingSource.DataMember = "DOCTOR";
            this.dOCTORBindingSource.DataSource = this.database1DataSet;
            // 
            // doctor_NameTextBox
            // 
            this.doctor_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dOCTORBindingSource, "Doctor_Name", true));
            this.doctor_NameTextBox.Location = new System.Drawing.Point(103, 53);
            this.doctor_NameTextBox.Name = "doctor_NameTextBox";
            this.doctor_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.doctor_NameTextBox.TabIndex = 8;
            // 
            // doctor_DeptTextBox
            // 
            this.doctor_DeptTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dOCTORBindingSource, "Doctor_Dept", true));
            this.doctor_DeptTextBox.Location = new System.Drawing.Point(103, 79);
            this.doctor_DeptTextBox.Name = "doctor_DeptTextBox";
            this.doctor_DeptTextBox.Size = new System.Drawing.Size(100, 20);
            this.doctor_DeptTextBox.TabIndex = 10;
            // 
            // dOCTORDataGridView
            // 
            this.dOCTORDataGridView.AutoGenerateColumns = false;
            this.dOCTORDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dOCTORDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dOCTORDataGridView.DataSource = this.dOCTORBindingSource;
            this.dOCTORDataGridView.Location = new System.Drawing.Point(432, 53);
            this.dOCTORDataGridView.Name = "dOCTORDataGridView";
            this.dOCTORDataGridView.Size = new System.Drawing.Size(343, 121);
            this.dOCTORDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Doctor_Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Doctor_Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Doctor_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Doctor_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Doctor_Dept";
            this.dataGridViewTextBoxColumn3.HeaderText = "Doctor_Dept";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.btn_ref_serial);
            this.tabPage3.Controls.Add(this.btn_serial);
            this.tabPage3.Controls.Add(this.sERIALDataGridView);
            this.tabPage3.Controls.Add(doctor_IdLabel1);
            this.tabPage3.Controls.Add(this.doctor_IdTextBox1);
            this.tabPage3.Controls.Add(patient_IdLabel);
            this.tabPage3.Controls.Add(this.patient_IdTextBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(797, 361);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Serial";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_ref_serial
            // 
            this.btn_ref_serial.Location = new System.Drawing.Point(158, 186);
            this.btn_ref_serial.Name = "btn_ref_serial";
            this.btn_ref_serial.Size = new System.Drawing.Size(81, 35);
            this.btn_ref_serial.TabIndex = 8;
            this.btn_ref_serial.Text = "Refresh";
            this.btn_ref_serial.UseVisualStyleBackColor = true;
            // 
            // btn_serial
            // 
            this.btn_serial.Location = new System.Drawing.Point(37, 186);
            this.btn_serial.Name = "btn_serial";
            this.btn_serial.Size = new System.Drawing.Size(81, 35);
            this.btn_serial.TabIndex = 7;
            this.btn_serial.Text = "Add Serial";
            this.btn_serial.UseVisualStyleBackColor = true;
            this.btn_serial.Click += new System.EventHandler(this.btn_serial_Click);
            // 
            // sERIALDataGridView
            // 
            this.sERIALDataGridView.AutoGenerateColumns = false;
            this.sERIALDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sERIALDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.sERIALDataGridView.DataSource = this.sERIALBindingSource;
            this.sERIALDataGridView.Location = new System.Drawing.Point(369, 31);
            this.sERIALDataGridView.Name = "sERIALDataGridView";
            this.sERIALDataGridView.Size = new System.Drawing.Size(350, 220);
            this.sERIALDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Serial_Id";
            this.dataGridViewTextBoxColumn4.HeaderText = "Serial_Id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Doctor_Id";
            this.dataGridViewTextBoxColumn5.HeaderText = "Doctor_Id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Patient_Id";
            this.dataGridViewTextBoxColumn6.HeaderText = "Patient_Id";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // sERIALBindingSource
            // 
            this.sERIALBindingSource.DataMember = "SERIAL";
            this.sERIALBindingSource.DataSource = this.database1DataSet;
            // 
            // doctor_IdTextBox1
            // 
            this.doctor_IdTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sERIALBindingSource, "Doctor_Id", true));
            this.doctor_IdTextBox1.Location = new System.Drawing.Point(95, 76);
            this.doctor_IdTextBox1.Name = "doctor_IdTextBox1";
            this.doctor_IdTextBox1.Size = new System.Drawing.Size(100, 20);
            this.doctor_IdTextBox1.TabIndex = 3;
            // 
            // patient_IdTextBox
            // 
            this.patient_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sERIALBindingSource, "Patient_Id", true));
            this.patient_IdTextBox.Location = new System.Drawing.Point(95, 102);
            this.patient_IdTextBox.Name = "patient_IdTextBox";
            this.patient_IdTextBox.Size = new System.Drawing.Size(100, 20);
            this.patient_IdTextBox.TabIndex = 5;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.rOOMDataGridView);
            this.tabPage4.Controls.Add(room_IdLabel);
            this.tabPage4.Controls.Add(this.room_IdTextBox);
            this.tabPage4.Controls.Add(patient_IdLabel1);
            this.tabPage4.Controls.Add(this.patient_IdTextBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(797, 361);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Room";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "book room";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.book_room_click);
            // 
            // rOOMDataGridView
            // 
            this.rOOMDataGridView.AutoGenerateColumns = false;
            this.rOOMDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rOOMDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.rOOMDataGridView.DataSource = this.rOOMBindingSource;
            this.rOOMDataGridView.Location = new System.Drawing.Point(444, 75);
            this.rOOMDataGridView.Name = "rOOMDataGridView";
            this.rOOMDataGridView.Size = new System.Drawing.Size(246, 220);
            this.rOOMDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Room_Id";
            this.dataGridViewTextBoxColumn7.HeaderText = "Room_Id";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Patient_Id";
            this.dataGridViewTextBoxColumn8.HeaderText = "Patient_Id";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // rOOMBindingSource
            // 
            this.rOOMBindingSource.DataMember = "ROOM";
            this.rOOMBindingSource.DataSource = this.database1DataSet;
            // 
            // room_IdTextBox
            // 
            this.room_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rOOMBindingSource, "Room_Id", true));
            this.room_IdTextBox.Location = new System.Drawing.Point(97, 52);
            this.room_IdTextBox.Name = "room_IdTextBox";
            this.room_IdTextBox.Size = new System.Drawing.Size(100, 20);
            this.room_IdTextBox.TabIndex = 1;
            // 
            // patient_IdTextBox1
            // 
            this.patient_IdTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rOOMBindingSource, "Patient_Id", true));
            this.patient_IdTextBox1.Location = new System.Drawing.Point(97, 78);
            this.patient_IdTextBox1.Name = "patient_IdTextBox1";
            this.patient_IdTextBox1.Size = new System.Drawing.Size(100, 20);
            this.patient_IdTextBox1.TabIndex = 3;
            // 
            // tabPage5
            // 
            this.tabPage5.AutoScroll = true;
            this.tabPage5.Controls.Add(this.pay_btn);
            this.tabPage5.Controls.Add(patient_IdLabel2);
            this.tabPage5.Controls.Add(this.pay_txt_pat_id);
            this.tabPage5.Controls.Add(date_Bill_PaidLabel);
            this.tabPage5.Controls.Add(this.date_Bill_PaidDateTimePicker);
            this.tabPage5.Controls.Add(total_AmountLabel);
            this.tabPage5.Controls.Add(this.pay_txt_total_amount);
            this.tabPage5.Controls.Add(this.pAYMENTDataGridView);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(797, 361);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Payments";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // pay_btn
            // 
            this.pay_btn.BackColor = System.Drawing.Color.Silver;
            this.pay_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay_btn.Location = new System.Drawing.Point(556, 26);
            this.pay_btn.Name = "pay_btn";
            this.pay_btn.Size = new System.Drawing.Size(89, 49);
            this.pay_btn.TabIndex = 9;
            this.pay_btn.Text = "Paid";
            this.pay_btn.UseVisualStyleBackColor = false;
            this.pay_btn.Click += new System.EventHandler(this.pay_btn_Click);
            // 
            // pay_txt_pat_id
            // 
            this.pay_txt_pat_id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pAYMENTBindingSource, "Patient_Id", true));
            this.pay_txt_pat_id.Location = new System.Drawing.Point(220, 23);
            this.pay_txt_pat_id.Name = "pay_txt_pat_id";
            this.pay_txt_pat_id.Size = new System.Drawing.Size(200, 20);
            this.pay_txt_pat_id.TabIndex = 4;
            // 
            // pAYMENTBindingSource
            // 
            this.pAYMENTBindingSource.DataMember = "PAYMENT";
            this.pAYMENTBindingSource.DataSource = this.database1DataSet;
            // 
            // date_Bill_PaidDateTimePicker
            // 
            this.date_Bill_PaidDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pAYMENTBindingSource, "Date_Bill_Paid", true));
            this.date_Bill_PaidDateTimePicker.Location = new System.Drawing.Point(220, 49);
            this.date_Bill_PaidDateTimePicker.Name = "date_Bill_PaidDateTimePicker";
            this.date_Bill_PaidDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_Bill_PaidDateTimePicker.TabIndex = 6;
            // 
            // pay_txt_total_amount
            // 
            this.pay_txt_total_amount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pAYMENTBindingSource, "Total_Amount", true));
            this.pay_txt_total_amount.Location = new System.Drawing.Point(220, 75);
            this.pay_txt_total_amount.Name = "pay_txt_total_amount";
            this.pay_txt_total_amount.Size = new System.Drawing.Size(200, 20);
            this.pay_txt_total_amount.TabIndex = 8;
            // 
            // pAYMENTDataGridView
            // 
            this.pAYMENTDataGridView.AutoGenerateColumns = false;
            this.pAYMENTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pAYMENTDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.pAYMENTDataGridView.DataSource = this.pAYMENTBindingSource;
            this.pAYMENTDataGridView.Location = new System.Drawing.Point(138, 141);
            this.pAYMENTDataGridView.Name = "pAYMENTDataGridView";
            this.pAYMENTDataGridView.Size = new System.Drawing.Size(541, 220);
            this.pAYMENTDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Payment_Bill_Id";
            this.dataGridViewTextBoxColumn9.HeaderText = "Payment_Bill_Id";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Patient_Id";
            this.dataGridViewTextBoxColumn10.HeaderText = "Patient_Id";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Date_Bill_Paid";
            this.dataGridViewTextBoxColumn11.HeaderText = "Date_Bill_Paid";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 150;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Total_Amount";
            this.dataGridViewTextBoxColumn12.HeaderText = "Total_Amount";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 150;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.h_PhoneTextBox);
            this.tabPage7.Controls.Add(this.weightTextBox);
            this.tabPage7.Controls.Add(this.phoneTextBox);
            this.tabPage7.Controls.Add(this.heightTextBox);
            this.tabPage7.Controls.Add(this.l_NameTextBox);
            this.tabPage7.Controls.Add(this.f_NameTextBox);
            this.tabPage7.Controls.Add(this.genderTextBox);
            this.tabPage7.Controls.Add(this.patient_IdTextBox2);
            this.tabPage7.Controls.Add(this.update_btn);
            this.tabPage7.Controls.Add(this.delete_btn);
            this.tabPage7.Controls.Add(this.label11);
            this.tabPage7.Controls.Add(this.label10);
            this.tabPage7.Controls.Add(label9);
            this.tabPage7.Controls.Add(this.txt_pat_delete);
            this.tabPage7.Controls.Add(patient_IdLabel3);
            this.tabPage7.Controls.Add(genderLabel);
            this.tabPage7.Controls.Add(dOBLabel);
            this.tabPage7.Controls.Add(this.dOBDateTimePicker);
            this.tabPage7.Controls.Add(f_NameLabel);
            this.tabPage7.Controls.Add(l_NameLabel);
            this.tabPage7.Controls.Add(heightLabel);
            this.tabPage7.Controls.Add(weightLabel);
            this.tabPage7.Controls.Add(phoneLabel);
            this.tabPage7.Controls.Add(h_PhoneLabel);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(797, 361);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Update & Delete";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // h_PhoneTextBox
            // 
            this.h_PhoneTextBox.Location = new System.Drawing.Point(100, 260);
            this.h_PhoneTextBox.Name = "h_PhoneTextBox";
            this.h_PhoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.h_PhoneTextBox.TabIndex = 31;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(100, 212);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(200, 20);
            this.weightTextBox.TabIndex = 30;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(100, 234);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.phoneTextBox.TabIndex = 29;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(100, 189);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(200, 20);
            this.heightTextBox.TabIndex = 28;
            // 
            // l_NameTextBox
            // 
            this.l_NameTextBox.Location = new System.Drawing.Point(100, 163);
            this.l_NameTextBox.Name = "l_NameTextBox";
            this.l_NameTextBox.Size = new System.Drawing.Size(200, 20);
            this.l_NameTextBox.TabIndex = 27;
            // 
            // f_NameTextBox
            // 
            this.f_NameTextBox.Location = new System.Drawing.Point(100, 137);
            this.f_NameTextBox.Name = "f_NameTextBox";
            this.f_NameTextBox.Size = new System.Drawing.Size(200, 20);
            this.f_NameTextBox.TabIndex = 26;
            // 
            // genderTextBox
            // 
            this.genderTextBox.Location = new System.Drawing.Point(100, 82);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(200, 20);
            this.genderTextBox.TabIndex = 25;
            // 
            // patient_IdTextBox2
            // 
            this.patient_IdTextBox2.Location = new System.Drawing.Point(100, 52);
            this.patient_IdTextBox2.Name = "patient_IdTextBox2";
            this.patient_IdTextBox2.Size = new System.Drawing.Size(200, 20);
            this.patient_IdTextBox2.TabIndex = 24;
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(80, 315);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(200, 23);
            this.update_btn.TabIndex = 23;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(495, 163);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(200, 23);
            this.delete_btn.TabIndex = 22;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 25);
            this.label11.TabIndex = 21;
            this.label11.Text = "Update";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(437, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "Delete";
            // 
            // txt_pat_delete
            // 
            this.txt_pat_delete.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pATIENTBindingSource1, "Patient_Id", true));
            this.txt_pat_delete.Location = new System.Drawing.Point(495, 105);
            this.txt_pat_delete.Name = "txt_pat_delete";
            this.txt_pat_delete.Size = new System.Drawing.Size(200, 20);
            this.txt_pat_delete.TabIndex = 19;
            // 
            // dOBDateTimePicker
            // 
            this.dOBDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pATIENTBindingSource1, "DOB", true));
            this.dOBDateTimePicker.Location = new System.Drawing.Point(100, 108);
            this.dOBDateTimePicker.Name = "dOBDateTimePicker";
            this.dOBDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dOBDateTimePicker.TabIndex = 5;
            // 
            // pATIENTBindingSource
            // 
            this.pATIENTBindingSource.DataMember = "PATIENT";
            this.pATIENTBindingSource.DataSource = this.database1DataSet;
            // 
            // dOCTORTableAdapter
            // 
            this.dOCTORTableAdapter.ClearBeforeFill = true;
            // 
            // pATIENTTableAdapter
            // 
            this.pATIENTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DOCTORTableAdapter = this.dOCTORTableAdapter;
            this.tableAdapterManager.PATIENTTableAdapter = this.pATIENTTableAdapter;
            this.tableAdapterManager.PAYMENTTableAdapter = null;
            this.tableAdapterManager.ROOMTableAdapter = null;
            this.tableAdapterManager.SERIALTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = database_project.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dOCTORBindingSource1
            // 
            this.dOCTORBindingSource1.DataMember = "DOCTOR";
            this.dOCTORBindingSource1.DataSource = this.database1DataSet;
            // 
            // sERIALTableAdapter
            // 
            this.sERIALTableAdapter.ClearBeforeFill = true;
            // 
            // rOOMTableAdapter
            // 
            this.rOOMTableAdapter.ClearBeforeFill = true;
            // 
            // pAYMENTTableAdapter
            // 
            this.pAYMENTTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 391);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hospital Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORDataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sERIALDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERIALBindingSource)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rOOMDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOOMBindingSource)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pAYMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAYMENTDataGridView)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtl_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtf_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtH_phone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource dOCTORBindingSource;
        private Database1DataSetTableAdapters.DOCTORTableAdapter dOCTORTableAdapter;
        private System.Windows.Forms.BindingSource pATIENTBindingSource;
        private Database1DataSetTableAdapters.PATIENTTableAdapter pATIENTTableAdapter;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_ref;
        private System.Windows.Forms.Button btn_doctor_add;
        private System.Windows.Forms.TextBox doctor_IdTextBox;
        private System.Windows.Forms.TextBox doctor_NameTextBox;
        private System.Windows.Forms.TextBox doctor_DeptTextBox;
        private System.Windows.Forms.DataGridView dOCTORDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource dOCTORBindingSource1;
        private System.Windows.Forms.BindingSource sERIALBindingSource;
        private Database1DataSetTableAdapters.SERIALTableAdapter sERIALTableAdapter;
        private System.Windows.Forms.Button btn_ref_serial;
        private System.Windows.Forms.Button btn_serial;
        private System.Windows.Forms.DataGridView sERIALDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox doctor_IdTextBox1;
        private System.Windows.Forms.TextBox patient_IdTextBox;
        private System.Windows.Forms.BindingSource pATIENTBindingSource1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource rOOMBindingSource;
        private Database1DataSetTableAdapters.ROOMTableAdapter rOOMTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView rOOMDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox room_IdTextBox;
        private System.Windows.Forms.TextBox patient_IdTextBox1;
        private System.Windows.Forms.BindingSource pAYMENTBindingSource;
        private Database1DataSetTableAdapters.PAYMENTTableAdapter pAYMENTTableAdapter;
        private System.Windows.Forms.DataGridView pAYMENTDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.TextBox pay_txt_pat_id;
        private System.Windows.Forms.DateTimePicker date_Bill_PaidDateTimePicker;
        private System.Windows.Forms.TextBox pay_txt_total_amount;
        private System.Windows.Forms.Button pay_btn;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_pat_delete;
        private System.Windows.Forms.DateTimePicker dOBDateTimePicker;
        private System.Windows.Forms.TextBox h_PhoneTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox l_NameTextBox;
        private System.Windows.Forms.TextBox f_NameTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox patient_IdTextBox2;
        private System.Windows.Forms.DateTimePicker txt_Dob;

    }
}

