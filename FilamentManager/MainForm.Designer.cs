namespace FilamentManager
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.btnActFact = new MetroFramework.Controls.MetroLink();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.newFilament = new MetroFramework.Controls.MetroToggle();
            this.gbBarcode = new System.Windows.Forms.GroupBox();
            this.btnSaveBarcode = new MetroFramework.Controls.MetroLink();
            this.btnFilaDelete = new MetroFramework.Controls.MetroLink();
            this.btnFilaAdd = new MetroFramework.Controls.MetroLink();
            this.btnGenBarcode = new MetroFramework.Controls.MetroLink();
            this.txtGenBarcode = new MetroFramework.Controls.MetroTextBox();
            this.txtNetto = new MetroFramework.Controls.MetroTextBox();
            this.txtBrutto = new MetroFramework.Controls.MetroTextBox();
            this.txtColor = new MetroFramework.Controls.MetroTextBox();
            this.cbFactory = new MetroFramework.Controls.MetroComboBox();
            this.gvFi = new MetroFramework.Controls.MetroGrid();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.gvJobs = new MetroFramework.Controls.MetroGrid();
            this.btnDelPrintJob = new MetroFramework.Controls.MetroLink();
            this.btnAddPrintJob = new MetroFramework.Controls.MetroLink();
            this.cbMaterial = new MetroFramework.Controls.MetroComboBox();
            this.txtPrintWeight = new MetroFramework.Controls.MetroTextBox();
            this.txtPrintID = new MetroFramework.Controls.MetroTextBox();
            this.cbPrintOs = new MetroFramework.Controls.MetroComboBox();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.flpSettings = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBackup = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.btnRestore = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cbLabelLocation = new MetroFramework.Controls.MetroComboBox();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.btnForeColor = new System.Windows.Forms.Button();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.cbRotateFlip = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.chkGenerateLabel = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtHeight = new MetroFramework.Controls.MetroTextBox();
            this.txtWidth = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbBarcodeAlign = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbEncodeType = new MetroFramework.Controls.MetroComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConTest = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtDB = new MetroFramework.Controls.MetroTextBox();
            this.txtUser = new MetroFramework.Controls.MetroTextBox();
            this.txtHost = new MetroFramework.Controls.MetroTextBox();
            this.lnlClose = new MetroFramework.Controls.MetroLink();
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvFi)).BeginInit();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvJobs)).BeginInit();
            this.metroTabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(1160, 600);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.btnActFact);
            this.metroTabPage2.Controls.Add(this.metroLabel8);
            this.metroTabPage2.Controls.Add(this.newFilament);
            this.metroTabPage2.Controls.Add(this.gbBarcode);
            this.metroTabPage2.Controls.Add(this.btnSaveBarcode);
            this.metroTabPage2.Controls.Add(this.btnFilaDelete);
            this.metroTabPage2.Controls.Add(this.btnFilaAdd);
            this.metroTabPage2.Controls.Add(this.btnGenBarcode);
            this.metroTabPage2.Controls.Add(this.txtGenBarcode);
            this.metroTabPage2.Controls.Add(this.txtNetto);
            this.metroTabPage2.Controls.Add(this.txtBrutto);
            this.metroTabPage2.Controls.Add(this.txtColor);
            this.metroTabPage2.Controls.Add(this.cbFactory);
            this.metroTabPage2.Controls.Add(this.gvFi);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 44);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1152, 552);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Filament";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // btnActFact
            // 
            this.btnActFact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActFact.Image = global::FilamentManager.Properties.Resources.restart;
            this.btnActFact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActFact.ImageSize = 30;
            this.btnActFact.Location = new System.Drawing.Point(299, 3);
            this.btnActFact.Name = "btnActFact";
            this.btnActFact.NoFocusImage = global::FilamentManager.Properties.Resources.restart;
            this.btnActFact.Size = new System.Drawing.Size(30, 30);
            this.btnActFact.TabIndex = 43;
            this.btnActFact.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActFact.UseSelectable = true;
            this.btnActFact.Click += new System.EventHandler(this.btnActFact_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.Location = new System.Drawing.Point(355, 108);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(100, 32);
            this.metroLabel8.TabIndex = 42;
            this.metroLabel8.Text = "Neues Filament";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newFilament
            // 
            this.newFilament.DisplayStatus = false;
            this.newFilament.Location = new System.Drawing.Point(297, 108);
            this.newFilament.Name = "newFilament";
            this.newFilament.Size = new System.Drawing.Size(52, 32);
            this.newFilament.TabIndex = 41;
            this.newFilament.Text = "Aus";
            this.newFilament.UseSelectable = true;
            this.newFilament.CheckedChanged += new System.EventHandler(this.newFilament_CheckedChanged);
            // 
            // gbBarcode
            // 
            this.gbBarcode.BackColor = System.Drawing.Color.Transparent;
            this.gbBarcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbBarcode.Location = new System.Drawing.Point(789, 3);
            this.gbBarcode.Name = "gbBarcode";
            this.gbBarcode.Size = new System.Drawing.Size(360, 229);
            this.gbBarcode.TabIndex = 39;
            this.gbBarcode.TabStop = false;
            this.gbBarcode.Text = "Barcode";
            // 
            // btnSaveBarcode
            // 
            this.btnSaveBarcode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveBarcode.Image = global::FilamentManager.Properties.Resources.saveing;
            this.btnSaveBarcode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveBarcode.ImageSize = 50;
            this.btnSaveBarcode.Location = new System.Drawing.Point(733, 18);
            this.btnSaveBarcode.Name = "btnSaveBarcode";
            this.btnSaveBarcode.NoFocusImage = global::FilamentManager.Properties.Resources.saveing;
            this.btnSaveBarcode.Size = new System.Drawing.Size(50, 50);
            this.btnSaveBarcode.TabIndex = 40;
            this.btnSaveBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveBarcode.UseSelectable = true;
            this.btnSaveBarcode.Click += new System.EventHandler(this.btnSaveBarcode_Click);
            // 
            // btnFilaDelete
            // 
            this.btnFilaDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilaDelete.Image = global::FilamentManager.Properties.Resources.minus;
            this.btnFilaDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilaDelete.ImageSize = 50;
            this.btnFilaDelete.Location = new System.Drawing.Point(59, 188);
            this.btnFilaDelete.Name = "btnFilaDelete";
            this.btnFilaDelete.NoFocusImage = global::FilamentManager.Properties.Resources.minus;
            this.btnFilaDelete.Size = new System.Drawing.Size(50, 50);
            this.btnFilaDelete.TabIndex = 38;
            this.btnFilaDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilaDelete.UseSelectable = true;
            this.btnFilaDelete.Click += new System.EventHandler(this.btnFilaDelete_Click);
            // 
            // btnFilaAdd
            // 
            this.btnFilaAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilaAdd.Image = global::FilamentManager.Properties.Resources.plus;
            this.btnFilaAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilaAdd.ImageSize = 50;
            this.btnFilaAdd.Location = new System.Drawing.Point(3, 188);
            this.btnFilaAdd.Name = "btnFilaAdd";
            this.btnFilaAdd.NoFocusImage = global::FilamentManager.Properties.Resources.plus;
            this.btnFilaAdd.Size = new System.Drawing.Size(50, 50);
            this.btnFilaAdd.TabIndex = 36;
            this.btnFilaAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilaAdd.UseSelectable = true;
            this.btnFilaAdd.Click += new System.EventHandler(this.btnFilaAdd_Click);
            // 
            // btnGenBarcode
            // 
            this.btnGenBarcode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenBarcode.Image = global::FilamentManager.Properties.Resources.Barcode;
            this.btnGenBarcode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenBarcode.ImageSize = 50;
            this.btnGenBarcode.Location = new System.Drawing.Point(175, 188);
            this.btnGenBarcode.Name = "btnGenBarcode";
            this.btnGenBarcode.NoFocusImage = global::FilamentManager.Properties.Resources.Barcode;
            this.btnGenBarcode.Size = new System.Drawing.Size(116, 50);
            this.btnGenBarcode.TabIndex = 35;
            this.btnGenBarcode.Text = "ERZEUGEN";
            this.btnGenBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenBarcode.UseSelectable = true;
            this.btnGenBarcode.Click += new System.EventHandler(this.btnGenBarcode_Click);
            // 
            // txtGenBarcode
            // 
            // 
            // 
            // 
            this.txtGenBarcode.CustomButton.Image = null;
            this.txtGenBarcode.CustomButton.Location = new System.Drawing.Point(260, 2);
            this.txtGenBarcode.CustomButton.Name = "";
            this.txtGenBarcode.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtGenBarcode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGenBarcode.CustomButton.TabIndex = 1;
            this.txtGenBarcode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGenBarcode.CustomButton.UseSelectable = true;
            this.txtGenBarcode.CustomButton.Visible = false;
            this.txtGenBarcode.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtGenBarcode.Lines = new string[0];
            this.txtGenBarcode.Location = new System.Drawing.Point(3, 152);
            this.txtGenBarcode.MaxLength = 32767;
            this.txtGenBarcode.Name = "txtGenBarcode";
            this.txtGenBarcode.PasswordChar = '\0';
            this.txtGenBarcode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGenBarcode.SelectedText = "";
            this.txtGenBarcode.SelectionLength = 0;
            this.txtGenBarcode.SelectionStart = 0;
            this.txtGenBarcode.Size = new System.Drawing.Size(288, 30);
            this.txtGenBarcode.TabIndex = 29;
            this.txtGenBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGenBarcode.UseSelectable = true;
            this.txtGenBarcode.WaterMark = "Barcode...";
            this.txtGenBarcode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGenBarcode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtNetto
            // 
            this.txtNetto.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.txtNetto.CustomButton.Image = null;
            this.txtNetto.CustomButton.Location = new System.Drawing.Point(260, 2);
            this.txtNetto.CustomButton.Name = "";
            this.txtNetto.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtNetto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNetto.CustomButton.TabIndex = 1;
            this.txtNetto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNetto.CustomButton.UseSelectable = true;
            this.txtNetto.CustomButton.Visible = false;
            this.txtNetto.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtNetto.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtNetto.Lines = new string[0];
            this.txtNetto.Location = new System.Drawing.Point(3, 116);
            this.txtNetto.MaxLength = 32767;
            this.txtNetto.Name = "txtNetto";
            this.txtNetto.PasswordChar = '\0';
            this.txtNetto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNetto.SelectedText = "";
            this.txtNetto.SelectionLength = 0;
            this.txtNetto.SelectionStart = 0;
            this.txtNetto.Size = new System.Drawing.Size(288, 30);
            this.txtNetto.TabIndex = 28;
            this.txtNetto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNetto.UseCustomBackColor = true;
            this.txtNetto.UseSelectable = true;
            this.txtNetto.WaterMark = "Netto[g]";
            this.txtNetto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNetto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtBrutto
            // 
            // 
            // 
            // 
            this.txtBrutto.CustomButton.Image = null;
            this.txtBrutto.CustomButton.Location = new System.Drawing.Point(260, 2);
            this.txtBrutto.CustomButton.Name = "";
            this.txtBrutto.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtBrutto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBrutto.CustomButton.TabIndex = 1;
            this.txtBrutto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBrutto.CustomButton.UseSelectable = true;
            this.txtBrutto.CustomButton.Visible = false;
            this.txtBrutto.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtBrutto.Lines = new string[0];
            this.txtBrutto.Location = new System.Drawing.Point(3, 80);
            this.txtBrutto.MaxLength = 32767;
            this.txtBrutto.Name = "txtBrutto";
            this.txtBrutto.PasswordChar = '\0';
            this.txtBrutto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBrutto.SelectedText = "";
            this.txtBrutto.SelectionLength = 0;
            this.txtBrutto.SelectionStart = 0;
            this.txtBrutto.Size = new System.Drawing.Size(288, 30);
            this.txtBrutto.TabIndex = 27;
            this.txtBrutto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBrutto.UseSelectable = true;
            this.txtBrutto.WaterMark = "Brutto[g]";
            this.txtBrutto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBrutto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtColor
            // 
            // 
            // 
            // 
            this.txtColor.CustomButton.Image = null;
            this.txtColor.CustomButton.Location = new System.Drawing.Point(260, 2);
            this.txtColor.CustomButton.Name = "";
            this.txtColor.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtColor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtColor.CustomButton.TabIndex = 1;
            this.txtColor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtColor.CustomButton.UseSelectable = true;
            this.txtColor.CustomButton.Visible = false;
            this.txtColor.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtColor.Lines = new string[0];
            this.txtColor.Location = new System.Drawing.Point(3, 44);
            this.txtColor.MaxLength = 32767;
            this.txtColor.Name = "txtColor";
            this.txtColor.PasswordChar = '\0';
            this.txtColor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtColor.SelectedText = "";
            this.txtColor.SelectionLength = 0;
            this.txtColor.SelectionStart = 0;
            this.txtColor.Size = new System.Drawing.Size(288, 30);
            this.txtColor.TabIndex = 26;
            this.txtColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtColor.UseSelectable = true;
            this.txtColor.WaterMark = "Farbe";
            this.txtColor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtColor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // cbFactory
            // 
            this.cbFactory.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cbFactory.ItemHeight = 29;
            this.cbFactory.Items.AddRange(new object[] {
            "Auswählen..."});
            this.cbFactory.Location = new System.Drawing.Point(3, 3);
            this.cbFactory.Name = "cbFactory";
            this.cbFactory.Size = new System.Drawing.Size(288, 35);
            this.cbFactory.TabIndex = 25;
            this.cbFactory.UseSelectable = true;
            // 
            // gvFi
            // 
            this.gvFi.AllowUserToAddRows = false;
            this.gvFi.AllowUserToDeleteRows = false;
            this.gvFi.AllowUserToResizeColumns = false;
            this.gvFi.AllowUserToResizeRows = false;
            this.gvFi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvFi.BackgroundColor = System.Drawing.Color.White;
            this.gvFi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvFi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvFi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gvFi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvFi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvFi.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvFi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gvFi.EnableHeadersVisualStyles = false;
            this.gvFi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gvFi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvFi.Location = new System.Drawing.Point(0, 249);
            this.gvFi.MultiSelect = false;
            this.gvFi.Name = "gvFi";
            this.gvFi.ReadOnly = true;
            this.gvFi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gvFi.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gvFi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gvFi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvFi.Size = new System.Drawing.Size(1152, 303);
            this.gvFi.TabIndex = 3;
            this.gvFi.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gvFi_MouseDoubleClick);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.txtDescription);
            this.metroTabPage1.Controls.Add(this.gvJobs);
            this.metroTabPage1.Controls.Add(this.btnDelPrintJob);
            this.metroTabPage1.Controls.Add(this.btnAddPrintJob);
            this.metroTabPage1.Controls.Add(this.cbMaterial);
            this.metroTabPage1.Controls.Add(this.txtPrintWeight);
            this.metroTabPage1.Controls.Add(this.txtPrintID);
            this.metroTabPage1.Controls.Add(this.cbPrintOs);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 44);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1152, 552);
            this.metroTabPage1.TabIndex = 3;
            this.metroTabPage1.Text = "Auftrag";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // gvJobs
            // 
            this.gvJobs.AllowUserToAddRows = false;
            this.gvJobs.AllowUserToDeleteRows = false;
            this.gvJobs.AllowUserToResizeColumns = false;
            this.gvJobs.AllowUserToResizeRows = false;
            this.gvJobs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvJobs.BackgroundColor = System.Drawing.Color.White;
            this.gvJobs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvJobs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvJobs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gvJobs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gvJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvJobs.DefaultCellStyle = dataGridViewCellStyle5;
            this.gvJobs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gvJobs.EnableHeadersVisualStyles = false;
            this.gvJobs.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gvJobs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvJobs.Location = new System.Drawing.Point(0, 249);
            this.gvJobs.MultiSelect = false;
            this.gvJobs.Name = "gvJobs";
            this.gvJobs.ReadOnly = true;
            this.gvJobs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gvJobs.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gvJobs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gvJobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvJobs.Size = new System.Drawing.Size(1152, 303);
            this.gvJobs.TabIndex = 41;
            // 
            // btnDelPrintJob
            // 
            this.btnDelPrintJob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelPrintJob.Image = global::FilamentManager.Properties.Resources.minus;
            this.btnDelPrintJob.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelPrintJob.ImageSize = 50;
            this.btnDelPrintJob.Location = new System.Drawing.Point(59, 193);
            this.btnDelPrintJob.Name = "btnDelPrintJob";
            this.btnDelPrintJob.NoFocusImage = global::FilamentManager.Properties.Resources.minus;
            this.btnDelPrintJob.Size = new System.Drawing.Size(50, 50);
            this.btnDelPrintJob.TabIndex = 40;
            this.btnDelPrintJob.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelPrintJob.UseSelectable = true;
            // 
            // btnAddPrintJob
            // 
            this.btnAddPrintJob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPrintJob.Image = global::FilamentManager.Properties.Resources.plus;
            this.btnAddPrintJob.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPrintJob.ImageSize = 50;
            this.btnAddPrintJob.Location = new System.Drawing.Point(3, 193);
            this.btnAddPrintJob.Name = "btnAddPrintJob";
            this.btnAddPrintJob.NoFocusImage = global::FilamentManager.Properties.Resources.plus;
            this.btnAddPrintJob.Size = new System.Drawing.Size(50, 50);
            this.btnAddPrintJob.TabIndex = 39;
            this.btnAddPrintJob.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddPrintJob.UseSelectable = true;
            this.btnAddPrintJob.Click += new System.EventHandler(this.btnAddPrintJob_Click);
            // 
            // cbMaterial
            // 
            this.cbMaterial.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cbMaterial.IntegralHeight = false;
            this.cbMaterial.ItemHeight = 29;
            this.cbMaterial.Items.AddRange(new object[] {
            "Auswählen..."});
            this.cbMaterial.Location = new System.Drawing.Point(3, 44);
            this.cbMaterial.MaxDropDownItems = 5;
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new System.Drawing.Size(288, 35);
            this.cbMaterial.TabIndex = 35;
            this.cbMaterial.UseSelectable = true;
            // 
            // txtPrintWeight
            // 
            this.txtPrintWeight.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.txtPrintWeight.CustomButton.Image = null;
            this.txtPrintWeight.CustomButton.Location = new System.Drawing.Point(260, 2);
            this.txtPrintWeight.CustomButton.Name = "";
            this.txtPrintWeight.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtPrintWeight.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrintWeight.CustomButton.TabIndex = 1;
            this.txtPrintWeight.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrintWeight.CustomButton.UseSelectable = true;
            this.txtPrintWeight.CustomButton.Visible = false;
            this.txtPrintWeight.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPrintWeight.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtPrintWeight.Lines = new string[0];
            this.txtPrintWeight.Location = new System.Drawing.Point(3, 157);
            this.txtPrintWeight.MaxLength = 32767;
            this.txtPrintWeight.Name = "txtPrintWeight";
            this.txtPrintWeight.PasswordChar = '\0';
            this.txtPrintWeight.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrintWeight.SelectedText = "";
            this.txtPrintWeight.SelectionLength = 0;
            this.txtPrintWeight.SelectionStart = 0;
            this.txtPrintWeight.Size = new System.Drawing.Size(288, 30);
            this.txtPrintWeight.TabIndex = 33;
            this.txtPrintWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrintWeight.UseCustomBackColor = true;
            this.txtPrintWeight.UseSelectable = true;
            this.txtPrintWeight.WaterMark = "Druck Gewicht";
            this.txtPrintWeight.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrintWeight.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtPrintID
            // 
            // 
            // 
            // 
            this.txtPrintID.CustomButton.Image = null;
            this.txtPrintID.CustomButton.Location = new System.Drawing.Point(260, 2);
            this.txtPrintID.CustomButton.Name = "";
            this.txtPrintID.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtPrintID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrintID.CustomButton.TabIndex = 1;
            this.txtPrintID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrintID.CustomButton.UseSelectable = true;
            this.txtPrintID.CustomButton.Visible = false;
            this.txtPrintID.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPrintID.Lines = new string[0];
            this.txtPrintID.Location = new System.Drawing.Point(3, 85);
            this.txtPrintID.MaxLength = 32767;
            this.txtPrintID.Name = "txtPrintID";
            this.txtPrintID.PasswordChar = '\0';
            this.txtPrintID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrintID.SelectedText = "";
            this.txtPrintID.SelectionLength = 0;
            this.txtPrintID.SelectionStart = 0;
            this.txtPrintID.Size = new System.Drawing.Size(288, 30);
            this.txtPrintID.TabIndex = 32;
            this.txtPrintID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrintID.UseSelectable = true;
            this.txtPrintID.WaterMark = "Druck ID";
            this.txtPrintID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrintID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // cbPrintOs
            // 
            this.cbPrintOs.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cbPrintOs.IntegralHeight = false;
            this.cbPrintOs.ItemHeight = 29;
            this.cbPrintOs.Items.AddRange(new object[] {
            "Auswählen..."});
            this.cbPrintOs.Location = new System.Drawing.Point(3, 3);
            this.cbPrintOs.Name = "cbPrintOs";
            this.cbPrintOs.Size = new System.Drawing.Size(288, 35);
            this.cbPrintOs.TabIndex = 30;
            this.cbPrintOs.UseSelectable = true;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.groupBox4);
            this.metroTabPage3.Controls.Add(this.groupBox3);
            this.metroTabPage3.Controls.Add(this.groupBox2);
            this.metroTabPage3.Controls.Add(this.groupBox1);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 44);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(1152, 552);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Einstellungen";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.metroLabel12);
            this.groupBox4.Controls.Add(this.flpSettings);
            this.groupBox4.Location = new System.Drawing.Point(561, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(241, 373);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Style";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(6, 18);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(42, 19);
            this.metroLabel12.TabIndex = 29;
            this.metroLabel12.Text = "Color";
            // 
            // flpSettings
            // 
            this.flpSettings.BackColor = System.Drawing.Color.Transparent;
            this.flpSettings.Location = new System.Drawing.Point(6, 40);
            this.flpSettings.Name = "flpSettings";
            this.flpSettings.Size = new System.Drawing.Size(229, 327);
            this.flpSettings.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnBackup);
            this.groupBox3.Controls.Add(this.btnRestore);
            this.groupBox3.Location = new System.Drawing.Point(3, 221);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 155);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Backup/Restore";
            // 
            // btnBackup
            // 
            this.btnBackup.Enabled = false;
            this.btnBackup.Image = null;
            this.btnBackup.Location = new System.Drawing.Point(6, 19);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(288, 53);
            this.btnBackup.TabIndex = 30;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseSelectable = true;
            this.btnBackup.UseVisualStyleBackColor = true;
            // 
            // btnRestore
            // 
            this.btnRestore.Enabled = false;
            this.btnRestore.Image = null;
            this.btnRestore.Location = new System.Drawing.Point(6, 90);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(288, 56);
            this.btnRestore.TabIndex = 29;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseSelectable = true;
            this.btnRestore.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.metroLabel7);
            this.groupBox2.Controls.Add(this.cbLabelLocation);
            this.groupBox2.Controls.Add(this.btnBackColor);
            this.groupBox2.Controls.Add(this.btnForeColor);
            this.groupBox2.Controls.Add(this.metroLabel6);
            this.groupBox2.Controls.Add(this.cbRotateFlip);
            this.groupBox2.Controls.Add(this.metroLabel5);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.chkGenerateLabel);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.txtHeight);
            this.groupBox2.Controls.Add(this.txtWidth);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.cbBarcodeAlign);
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Controls.Add(this.cbEncodeType);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(314, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 373);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Barcode";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(6, 223);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(93, 19);
            this.metroLabel7.TabIndex = 18;
            this.metroLabel7.Text = "Label Location";
            // 
            // cbLabelLocation
            // 
            this.cbLabelLocation.FormattingEnabled = true;
            this.cbLabelLocation.ItemHeight = 23;
            this.cbLabelLocation.Items.AddRange(new object[] {
            "BottomCenter",
            "BottomLeft",
            "BottomRight",
            "TopCenter",
            "TopLeft",
            "TopRight"});
            this.cbLabelLocation.Location = new System.Drawing.Point(5, 248);
            this.cbLabelLocation.Name = "cbLabelLocation";
            this.cbLabelLocation.Size = new System.Drawing.Size(229, 29);
            this.cbLabelLocation.TabIndex = 17;
            this.cbLabelLocation.UseSelectable = true;
            // 
            // btnBackColor
            // 
            this.btnBackColor.Location = new System.Drawing.Point(130, 328);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(79, 36);
            this.btnBackColor.TabIndex = 14;
            this.btnBackColor.UseVisualStyleBackColor = true;
            // 
            // btnForeColor
            // 
            this.btnForeColor.Location = new System.Drawing.Point(5, 328);
            this.btnForeColor.Name = "btnForeColor";
            this.btnForeColor.Size = new System.Drawing.Size(79, 36);
            this.btnForeColor.TabIndex = 13;
            this.btnForeColor.UseVisualStyleBackColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(8, 73);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(47, 19);
            this.metroLabel6.TabIndex = 16;
            this.metroLabel6.Text = "Rotate";
            // 
            // cbRotateFlip
            // 
            this.cbRotateFlip.FormattingEnabled = true;
            this.cbRotateFlip.ItemHeight = 23;
            this.cbRotateFlip.Items.AddRange(new object[] {
            "Center",
            "Left",
            "Right"});
            this.cbRotateFlip.Location = new System.Drawing.Point(7, 98);
            this.cbRotateFlip.Name = "cbRotateFlip";
            this.cbRotateFlip.Size = new System.Drawing.Size(229, 29);
            this.cbRotateFlip.TabIndex = 15;
            this.cbRotateFlip.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(130, 305);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(79, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Background";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(5, 305);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(79, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Foreground";
            // 
            // chkGenerateLabel
            // 
            this.chkGenerateLabel.AutoSize = true;
            this.chkGenerateLabel.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkGenerateLabel.Location = new System.Drawing.Point(6, 283);
            this.chkGenerateLabel.Name = "chkGenerateLabel";
            this.chkGenerateLabel.Size = new System.Drawing.Size(113, 19);
            this.chkGenerateLabel.TabIndex = 8;
            this.chkGenerateLabel.Text = "Generate label";
            this.chkGenerateLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.chkGenerateLabel.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(110, 190);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(15, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "x";
            // 
            // txtHeight
            // 
            // 
            // 
            // 
            this.txtHeight.CustomButton.Image = null;
            this.txtHeight.CustomButton.Location = new System.Drawing.Point(75, 2);
            this.txtHeight.CustomButton.Name = "";
            this.txtHeight.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtHeight.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHeight.CustomButton.TabIndex = 1;
            this.txtHeight.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHeight.CustomButton.UseSelectable = true;
            this.txtHeight.CustomButton.Visible = false;
            this.txtHeight.Lines = new string[0];
            this.txtHeight.Location = new System.Drawing.Point(131, 190);
            this.txtHeight.MaxLength = 32767;
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.PasswordChar = '\0';
            this.txtHeight.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHeight.SelectedText = "";
            this.txtHeight.SelectionLength = 0;
            this.txtHeight.SelectionStart = 0;
            this.txtHeight.Size = new System.Drawing.Size(103, 30);
            this.txtHeight.TabIndex = 5;
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHeight.UseSelectable = true;
            this.txtHeight.WaterMark = "Height";
            this.txtHeight.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHeight.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtWidth
            // 
            // 
            // 
            // 
            this.txtWidth.CustomButton.Image = null;
            this.txtWidth.CustomButton.Location = new System.Drawing.Point(70, 2);
            this.txtWidth.CustomButton.Name = "";
            this.txtWidth.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtWidth.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtWidth.CustomButton.TabIndex = 1;
            this.txtWidth.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtWidth.CustomButton.UseSelectable = true;
            this.txtWidth.CustomButton.Visible = false;
            this.txtWidth.Lines = new string[0];
            this.txtWidth.Location = new System.Drawing.Point(6, 190);
            this.txtWidth.MaxLength = 32767;
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.PasswordChar = '\0';
            this.txtWidth.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtWidth.SelectedText = "";
            this.txtWidth.SelectionLength = 0;
            this.txtWidth.SelectionStart = 0;
            this.txtWidth.Size = new System.Drawing.Size(98, 30);
            this.txtWidth.TabIndex = 4;
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWidth.UseSelectable = true;
            this.txtWidth.WaterMark = "Width";
            this.txtWidth.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtWidth.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 130);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(69, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Alignment";
            // 
            // cbBarcodeAlign
            // 
            this.cbBarcodeAlign.FormattingEnabled = true;
            this.cbBarcodeAlign.ItemHeight = 23;
            this.cbBarcodeAlign.Items.AddRange(new object[] {
            "Center",
            "Left",
            "Right"});
            this.cbBarcodeAlign.Location = new System.Drawing.Point(5, 155);
            this.cbBarcodeAlign.Name = "cbBarcodeAlign";
            this.cbBarcodeAlign.Size = new System.Drawing.Size(229, 29);
            this.cbBarcodeAlign.TabIndex = 2;
            this.cbBarcodeAlign.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(8, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Encoding";
            // 
            // cbEncodeType
            // 
            this.cbEncodeType.FormattingEnabled = true;
            this.cbEncodeType.ItemHeight = 23;
            this.cbEncodeType.Items.AddRange(new object[] {
            "UPC-A",
            "UPC-E",
            "UPC 2 Digit Ext.",
            "UPC 5 Digit Ext.",
            "EAN-13",
            "JAN-13",
            "EAN-8",
            "ITF-14",
            "Interleaved 2 of 5",
            "Standard 2 of 5",
            "Codabar",
            "PostNet",
            "Bookland/ISBN",
            "Code 11",
            "Code 39",
            "Code 39 Extended",
            "Code 39 Mod 43",
            "Code 93",
            "Code 128",
            "Code 128-A",
            "Code 128-B",
            "Code 128-C",
            "LOGMARS",
            "MSI",
            "Telepen",
            "FIM",
            "Pharmacode"});
            this.cbEncodeType.Location = new System.Drawing.Point(7, 41);
            this.cbEncodeType.Name = "cbEncodeType";
            this.cbEncodeType.Size = new System.Drawing.Size(229, 29);
            this.cbEncodeType.TabIndex = 0;
            this.cbEncodeType.UseSelectable = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnConTest);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtDB);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.txtHost);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 212);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MySQL -Datenbank";
            // 
            // btnConTest
            // 
            this.btnConTest.Image = null;
            this.btnConTest.Location = new System.Drawing.Point(6, 163);
            this.btnConTest.Name = "btnConTest";
            this.btnConTest.Size = new System.Drawing.Size(288, 40);
            this.btnConTest.TabIndex = 34;
            this.btnConTest.Text = "Test Verbindung";
            this.btnConTest.UseSelectable = true;
            this.btnConTest.UseVisualStyleBackColor = true;
            this.btnConTest.Click += new System.EventHandler(this.btnConTest_Click);
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(260, 2);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(6, 127);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.Size = new System.Drawing.Size(288, 30);
            this.txtPassword.TabIndex = 33;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMark = "Passwort";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtDB
            // 
            // 
            // 
            // 
            this.txtDB.CustomButton.Image = null;
            this.txtDB.CustomButton.Location = new System.Drawing.Point(260, 2);
            this.txtDB.CustomButton.Name = "";
            this.txtDB.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtDB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDB.CustomButton.TabIndex = 1;
            this.txtDB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDB.CustomButton.UseSelectable = true;
            this.txtDB.CustomButton.Visible = false;
            this.txtDB.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtDB.Lines = new string[0];
            this.txtDB.Location = new System.Drawing.Point(6, 91);
            this.txtDB.MaxLength = 32767;
            this.txtDB.Name = "txtDB";
            this.txtDB.PasswordChar = '\0';
            this.txtDB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDB.SelectedText = "";
            this.txtDB.SelectionLength = 0;
            this.txtDB.SelectionStart = 0;
            this.txtDB.Size = new System.Drawing.Size(288, 30);
            this.txtDB.TabIndex = 32;
            this.txtDB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDB.UseSelectable = true;
            this.txtDB.WaterMark = "Datenbank";
            this.txtDB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtUser
            // 
            // 
            // 
            // 
            this.txtUser.CustomButton.Image = null;
            this.txtUser.CustomButton.Location = new System.Drawing.Point(260, 2);
            this.txtUser.CustomButton.Name = "";
            this.txtUser.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUser.CustomButton.TabIndex = 1;
            this.txtUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUser.CustomButton.UseSelectable = true;
            this.txtUser.CustomButton.Visible = false;
            this.txtUser.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtUser.Lines = new string[0];
            this.txtUser.Location = new System.Drawing.Point(6, 55);
            this.txtUser.MaxLength = 32767;
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUser.SelectedText = "";
            this.txtUser.SelectionLength = 0;
            this.txtUser.SelectionStart = 0;
            this.txtUser.Size = new System.Drawing.Size(288, 30);
            this.txtUser.TabIndex = 31;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUser.UseSelectable = true;
            this.txtUser.WaterMark = "Username";
            this.txtUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtHost
            // 
            // 
            // 
            // 
            this.txtHost.CustomButton.Image = null;
            this.txtHost.CustomButton.Location = new System.Drawing.Point(260, 2);
            this.txtHost.CustomButton.Name = "";
            this.txtHost.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtHost.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHost.CustomButton.TabIndex = 1;
            this.txtHost.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHost.CustomButton.UseSelectable = true;
            this.txtHost.CustomButton.Visible = false;
            this.txtHost.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtHost.Lines = new string[0];
            this.txtHost.Location = new System.Drawing.Point(6, 19);
            this.txtHost.MaxLength = 32767;
            this.txtHost.Name = "txtHost";
            this.txtHost.PasswordChar = '\0';
            this.txtHost.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHost.SelectedText = "";
            this.txtHost.SelectionLength = 0;
            this.txtHost.SelectionStart = 0;
            this.txtHost.Size = new System.Drawing.Size(288, 30);
            this.txtHost.TabIndex = 30;
            this.txtHost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHost.UseSelectable = true;
            this.txtHost.WaterMark = "Adresse";
            this.txtHost.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHost.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lnlClose
            // 
            this.lnlClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnlClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnlClose.Image = global::FilamentManager.Properties.Resources.shutdown;
            this.lnlClose.ImageSize = 50;
            this.lnlClose.Location = new System.Drawing.Point(1144, 10);
            this.lnlClose.Name = "lnlClose";
            this.lnlClose.NoFocusImage = global::FilamentManager.Properties.Resources.shutdown;
            this.lnlClose.Size = new System.Drawing.Size(50, 50);
            this.lnlClose.TabIndex = 3;
            this.lnlClose.UseSelectable = true;
            this.lnlClose.Click += new System.EventHandler(this.lnlClose_Click);
            // 
            // msmMain
            // 
            this.msmMain.Owner = null;
            // 
            // txtDescription
            // 
            // 
            // 
            // 
            this.txtDescription.CustomButton.Image = null;
            this.txtDescription.CustomButton.Location = new System.Drawing.Point(260, 2);
            this.txtDescription.CustomButton.Name = "";
            this.txtDescription.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescription.CustomButton.TabIndex = 1;
            this.txtDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescription.CustomButton.UseSelectable = true;
            this.txtDescription.CustomButton.Visible = false;
            this.txtDescription.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtDescription.Lines = new string[0];
            this.txtDescription.Location = new System.Drawing.Point(3, 121);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.Size = new System.Drawing.Size(288, 30);
            this.txtDescription.TabIndex = 42;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDescription.UseSelectable = true;
            this.txtDescription.WaterMark = "Beschreibung";
            this.txtDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 680);
            this.ControlBox = false;
            this.Controls.Add(this.lnlClose);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "MainForm";
            this.Resizable = false;
            this.Text = "Filament-Manager";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvFi)).EndInit();
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvJobs)).EndInit();
            this.metroTabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroGrid gvFi;
        private MetroFramework.Controls.MetroLink btnFilaDelete;
        private MetroFramework.Controls.MetroLink btnFilaAdd;
        private MetroFramework.Controls.MetroLink btnGenBarcode;
        private MetroFramework.Controls.MetroTextBox txtGenBarcode;
        private MetroFramework.Controls.MetroTextBox txtNetto;
        private MetroFramework.Controls.MetroTextBox txtBrutto;
        private MetroFramework.Controls.MetroTextBox txtColor;
        private MetroFramework.Controls.MetroComboBox cbFactory;
        private System.Windows.Forms.GroupBox gbBarcode;
        private MetroFramework.Controls.MetroLink btnSaveBarcode;
        private MetroFramework.Controls.MetroLink lnlClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private System.Windows.Forms.FlowLayoutPanel flpSettings;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnBackup;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnRestore;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox cbLabelLocation;
        private System.Windows.Forms.Button btnBackColor;
        private System.Windows.Forms.Button btnForeColor;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroComboBox cbRotateFlip;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroCheckBox chkGenerateLabel;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtHeight;
        private MetroFramework.Controls.MetroTextBox txtWidth;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cbBarcodeAlign;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbEncodeType;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnConTest;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtDB;
        private MetroFramework.Controls.MetroTextBox txtUser;
        private MetroFramework.Controls.MetroTextBox txtHost;
        private MetroFramework.Components.MetroStyleManager msmMain;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroToggle newFilament;
        private MetroFramework.Controls.MetroLink btnActFact;
        private MetroFramework.Controls.MetroComboBox cbMaterial;
        private MetroFramework.Controls.MetroTextBox txtPrintWeight;
        private MetroFramework.Controls.MetroTextBox txtPrintID;
        private MetroFramework.Controls.MetroComboBox cbPrintOs;
        private MetroFramework.Controls.MetroLink btnDelPrintJob;
        private MetroFramework.Controls.MetroLink btnAddPrintJob;
        private MetroFramework.Controls.MetroGrid gvJobs;
        private MetroFramework.Controls.MetroTextBox txtDescription;
    }
}

