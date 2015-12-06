using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilamentManager
{
    public partial class MainForm : MetroForm
    {
        private MySqlConnection sqlCon;
        private MySqlCommand cmd;

        BarcodeLib.Barcode b = new BarcodeLib.Barcode();

        public MainForm()
        {
            InitializeComponent();
            loadSetting();
            SqlCon();
            listFactoryCb();
            listPrintOs();
            listFilament();
            cbFactory.SelectedIndex = 0;
            metroTabControl1.SelectedIndex = 0;
            DataGridFilament();
            DataGridPrintJob();
        }

        private void lnlClose_Click(object sender, EventArgs e)
        {
            saveSettings();
            this.Close();
        }

        private void SqlCon()
        {
            string conString = "server=" + txtHost.Text + ";user=" + txtUser.Text + ";database=" +
            txtDB.Text + ";password=" + txtPassword.Text + ";";

            sqlCon = new MySqlConnection(conString);
            
        }

        private void listFactoryCb()
        {
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT id, name FROM manufacturer", sqlCon);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbFactory.DataSource = dt;
                cbFactory.DisplayMember = "name";
                cbFactory.ValueMember = "id";
            }
            catch
            {

            }
            

        }
        
        private void listPrintOs()
        {
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT *FROM printOs", sqlCon);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbPrintOs.DataSource = dt;
                cbPrintOs.DisplayMember = "name";
                cbPrintOs.ValueMember = "id";
            }
            catch
            {

            }
            
        }

        private void listFilament()
        {
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT id, barcode FROM filament", sqlCon);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbMaterial.DataSource = dt;
                cbMaterial.DisplayMember = "barcode";
                cbMaterial.ValueMember = "id";
            }
            catch
            {

            }
            
        }

        private void btnSaveBarcode_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "BMP (*.bmp)|*.bmp|GIF (*.gif)|*.gif|JPG (*.jpg)|*.jpg|PNG (*.png)|*.png|TIFF (*.tif)|*.tif";
            sfd.FilterIndex = 4;
            sfd.AddExtension = true;
            sfd.FileName = "Barcode_" + txtGenBarcode.Text;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                BarcodeLib.SaveTypes savetype = BarcodeLib.SaveTypes.UNSPECIFIED;
                switch (sfd.FilterIndex)
                {
                    case 1: /* BMP */  savetype = BarcodeLib.SaveTypes.BMP; break;
                    case 2: /* GIF */  savetype = BarcodeLib.SaveTypes.GIF; break;
                    case 3: /* JPG */  savetype = BarcodeLib.SaveTypes.JPG; break;
                    case 4: /* PNG */  savetype = BarcodeLib.SaveTypes.PNG; break;
                    case 5: /* TIFF */ savetype = BarcodeLib.SaveTypes.TIFF; break;
                    default: break;
                }
                b.SaveImage(sfd.FileName, savetype);
            }
        }

        private void saveSettings()
        {
            Properties.Settings.Default.checkLabel = chkGenerateLabel.Checked;
            Properties.Settings.Default.lablLocation = cbBarcodeAlign.SelectedIndex;
            Properties.Settings.Default.btnForColor = btnForeColor.BackColor;
            Properties.Settings.Default.btnBackColor = btnBackColor.BackColor;
            Properties.Settings.Default.barcodeHeight = Convert.ToInt32(this.txtHeight.Text.Trim());
            Properties.Settings.Default.barcodeWidth = Convert.ToInt32(this.txtWidth.Text.Trim());
            Properties.Settings.Default.barcodeTyp = cbEncodeType.SelectedIndex;
            Properties.Settings.Default.labelpos = cbLabelLocation.SelectedIndex;
            Properties.Settings.Default.styleColor = msmMain.Style;
            Properties.Settings.Default.DBAdress = txtHost.Text;
            Properties.Settings.Default.DB = txtDB.Text;
            Properties.Settings.Default.User = txtUser.Text;
            Properties.Settings.Default.password = txtPassword.Text;
            Properties.Settings.Default.Save();
        }

        private void loadSetting()
        {
            chkGenerateLabel.Checked = Properties.Settings.Default.checkLabel;
            cbBarcodeAlign.SelectedIndex = Properties.Settings.Default.lablLocation;
            btnForeColor.BackColor = Properties.Settings.Default.btnForColor;
            btnBackColor.BackColor = Properties.Settings.Default.btnBackColor;
            txtWidth.Text = Convert.ToString(Properties.Settings.Default.barcodeWidth);
            txtHeight.Text = Convert.ToString(Properties.Settings.Default.barcodeHeight);
            cbEncodeType.SelectedIndex = Properties.Settings.Default.barcodeTyp;
            cbLabelLocation.SelectedIndex = Properties.Settings.Default.labelpos;
            txtHost.Text = Properties.Settings.Default.DBAdress;
            txtDB.Text = Properties.Settings.Default.DB;
            txtUser.Text = Properties.Settings.Default.User;
            txtPassword.Text = Properties.Settings.Default.password;
            msmMain.Style = Properties.Settings.Default.styleColor;


            this.cbRotateFlip.DataSource = System.Enum.GetNames(typeof(RotateFlipType));

            int i = 0;
            foreach (object o in cbRotateFlip.Items)
            {
                if (o.ToString().Trim().ToLower() == "rotatenoneflipnone")
                    break;
                i++;
            }//foreach
            this.cbRotateFlip.SelectedIndex = i;


        }

        private void btnGenBarcode_Click(object sender, EventArgs e)
        {
            if (txtGenBarcode.Text == "")
            {
                if (txtColor.Text == "" || cbFactory.Text == "Auswählen...")
                {
                    MetroMessageBox.Show(this, "Es wurde nicht alles ausgefüllt", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {

                    try
                    {
                        cmd = new MySqlCommand("SELECT ID FROM filament ORDER BY ID DESC LIMIT 1", sqlCon);
                    }
                    catch (MySqlException ex)
                    {
                        MetroMessageBox.Show(this, ex.Message, "DB ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }

                    try
                    {
                        int lastID;

                        sqlCon.Open();

                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            int nextID;
                            if (reader.GetInt32(0) == 0)
                            {
                                nextID = 1;
                                break;
                            }
                            else
                            {
                                lastID = reader.GetInt32(0);
                                nextID = lastID + 1;

                            }
                            txtGenBarcode.Text = txtColor.Text + "_" + nextID + "_" + cbFactory.Text;

                        }
                        sqlCon.Close();
                        BarcodeGenerator();

                    }
                    catch (Exception ex)
                    {
                        MetroMessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        sqlCon.Close();
                    }
                }
            }
            else
            {
                BarcodeGenerator();
            }
        }
        private void BarcodeGenerator()
        {
            int W = Convert.ToInt32(this.txtWidth.Text.Trim());
            int H = Convert.ToInt32(this.txtHeight.Text.Trim());
            b.Alignment = BarcodeLib.AlignmentPositions.CENTER;

            switch (cbBarcodeAlign.SelectedItem.ToString().Trim().ToLower())
            {
                case "left": b.Alignment = BarcodeLib.AlignmentPositions.LEFT; break;
                case "right": b.Alignment = BarcodeLib.AlignmentPositions.RIGHT; break;
                default: b.Alignment = BarcodeLib.AlignmentPositions.CENTER; break;
            }

            BarcodeLib.TYPE type = BarcodeLib.TYPE.UNSPECIFIED;
            switch (cbEncodeType.SelectedItem.ToString().Trim())
            {
                case "UPC-A": type = BarcodeLib.TYPE.UPCA; break;
                case "UPC-E": type = BarcodeLib.TYPE.UPCE; break;
                case "UPC 2 Digit Ext.": type = BarcodeLib.TYPE.UPC_SUPPLEMENTAL_2DIGIT; break;
                case "UPC 5 Digit Ext.": type = BarcodeLib.TYPE.UPC_SUPPLEMENTAL_5DIGIT; break;
                case "EAN-13": type = BarcodeLib.TYPE.EAN13; break;
                case "JAN-13": type = BarcodeLib.TYPE.JAN13; break;
                case "EAN-8": type = BarcodeLib.TYPE.EAN8; break;
                case "ITF-14": type = BarcodeLib.TYPE.ITF14; break;
                case "Codabar": type = BarcodeLib.TYPE.Codabar; break;
                case "PostNet": type = BarcodeLib.TYPE.PostNet; break;
                case "Bookland/ISBN": type = BarcodeLib.TYPE.BOOKLAND; break;
                case "Code 11": type = BarcodeLib.TYPE.CODE11; break;
                case "Code 39": type = BarcodeLib.TYPE.CODE39; break;
                case "Code 39 Extended": type = BarcodeLib.TYPE.CODE39Extended; break;
                case "Code 39 Mod 43": type = BarcodeLib.TYPE.CODE39_Mod43; break;
                case "Code 93": type = BarcodeLib.TYPE.CODE93; break;
                case "LOGMARS": type = BarcodeLib.TYPE.LOGMARS; break;
                case "MSI": type = BarcodeLib.TYPE.MSI_Mod10; break;
                case "Interleaved 2 of 5": type = BarcodeLib.TYPE.Interleaved2of5; break;
                case "Standard 2 of 5": type = BarcodeLib.TYPE.Standard2of5; break;
                case "Code 128": type = BarcodeLib.TYPE.CODE128; break;
                case "Code 128-A": type = BarcodeLib.TYPE.CODE128A; break;
                case "Code 128-B": type = BarcodeLib.TYPE.CODE128B; break;
                case "Code 128-C": type = BarcodeLib.TYPE.CODE128C; break;
                case "Telepen": type = BarcodeLib.TYPE.TELEPEN; break;
                case "FIM": type = BarcodeLib.TYPE.FIM; break;
                case "Pharmacode": type = BarcodeLib.TYPE.PHARMACODE; break;
                default: MessageBox.Show("Please specify the encoding type."); break;
            }
            try
            {
                if (type != BarcodeLib.TYPE.UNSPECIFIED)
                {
                    b.IncludeLabel = this.chkGenerateLabel.Checked;

                    b.RotateFlipType = (RotateFlipType)Enum.Parse(typeof(RotateFlipType), this.cbRotateFlip.SelectedItem.ToString(), true);

                    switch (this.cbLabelLocation.SelectedItem.ToString().Trim().ToUpper())
                    {
                        case "BOTTOMLEFT": b.LabelPosition = BarcodeLib.LabelPositions.BOTTOMLEFT; break;
                        case "BOTTOMRIGHT": b.LabelPosition = BarcodeLib.LabelPositions.BOTTOMRIGHT; break;
                        case "TOPCENTER": b.LabelPosition = BarcodeLib.LabelPositions.TOPCENTER; break;
                        case "TOPLEFT": b.LabelPosition = BarcodeLib.LabelPositions.TOPLEFT; break;
                        case "TOPRIGHT": b.LabelPosition = BarcodeLib.LabelPositions.TOPRIGHT; break;
                        default: b.LabelPosition = BarcodeLib.LabelPositions.BOTTOMCENTER; break;
                    }//switch

                    gbBarcode.BackgroundImage = b.Encode(type, this.txtGenBarcode.Text.Trim(), this.btnForeColor.BackColor, this.btnBackColor.BackColor, W, H);
                }
                gbBarcode.Location = new Point((this.gbBarcode.Location.X + this.gbBarcode.Width / 2) - gbBarcode.Width / 2, (this.gbBarcode.Location.Y + this.gbBarcode.Height / 2) - gbBarcode.Height / 2);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnConTest_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCon.Open();
                MetroMessageBox.Show(this, "Verbindung OK", "Erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.Write("Connect");
                sqlCon.Close();

            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MetroMessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        sqlCon.Close();
                        break;

                    case 1045:
                        MetroMessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        sqlCon.Close();
                        break;
                }
            }
        }

        private void newFilament_CheckedChanged(object sender, EventArgs e)
        {
            if (newFilament.Checked == true)
            {
                txtNetto.Enabled = false;
                txtNetto.BackColor = SystemColors.AppWorkspace;
            }
            else
            {
                txtNetto.Enabled = true;
                txtNetto.BackColor = SystemColors.Window;
            }
        }

        private void btnActFact_Click(object sender, EventArgs e)
        {
            listFactoryCb();
        }

        private void btnFilaAdd_Click(object sender, EventArgs e)
        {
            if (cbFactory.Text == "Auswählen..." || txtColor.Text == "" || txtBrutto.Text == "" || (txtNetto.Text == "" && newFilament.Checked == false))
            {
                MetroMessageBox.Show(this, "Es wurde nicht alles ausgefüllt", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                if(newFilament.Checked == true)
                {
                    txtNetto.Text = txtBrutto.Text;
                }

                if (txtGenBarcode.Text == "")
                {
                    MetroMessageBox.Show(this, "Barcode wurde nicht erstellt. Bitte erstellen sie einen Barcode", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        sqlCon.Open();
                        string query = "INSERT INTO filament (barcode, manuId, Color, brutto, netto, lastChange) VALUES ('" + txtGenBarcode.Text + "','" + cbFactory.SelectedValue + "','" + txtColor.Text + "','" + txtBrutto.Text + "','" + txtNetto.Text + "','" + Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd") + "')";
                        MySqlDataAdapter SDA = new MySqlDataAdapter(query, sqlCon);
                        SDA.SelectCommand.ExecuteNonQuery();
                        sqlCon.Close();
                        cleanFilament();
                        DataGridFilament();
                    }
                    catch (Exception ex)
                    {
                        MetroMessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        sqlCon.Close();
                    }

                }
            }
        }

        private void cleanFilament()
        {
            txtGenBarcode.Text = "";
            txtColor.Text = "";
            txtBrutto.Text = "";
            txtNetto.Text = "";
            txtGenBarcode.Text = "";
        }

        private void DataGridFilament()
        {
            try
            {
                sqlCon.Open();
                string query =  "SELECT filament.id, barcode, manufacturer.name, color, netto FROM filament "+
                                "Inner join manufacturer on filament.manuId = manufacturer.id";
                    
                MySqlDataAdapter SDA = new MySqlDataAdapter(query, sqlCon);
                DataTable DATA = new DataTable();
                SDA.Fill(DATA);
                gvFi.DataSource = DATA;
                gvFi.Columns[0].HeaderCell.Value = "Nr.";
                gvFi.Columns[1].HeaderCell.Value = "Barcode";
                gvFi.Columns[2].HeaderCell.Value = "Hersteller";
                gvFi.Columns[3].HeaderCell.Value = "Farbe";
                gvFi.Columns[4].HeaderCell.Value = "Gewicht[g]";

                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                sqlCon.Close();
            }

        }

        private void DataGridPrintJob()
        {
            try
            {
                sqlCon.Open();
                string query =  "SELECT printJobs.id, printOs.name, printID, filament.barcode, printWeight, printName FROM printJobs "+
                                "INNER join printOs on printJobs.printOsID = printOs.id "+
                                "INNER join filament on printJobs.materialID = filament.id";

                MySqlDataAdapter SDA = new MySqlDataAdapter(query, sqlCon);
                DataTable DATA = new DataTable();
                SDA.Fill(DATA);
                gvJobs.DataSource = DATA;
                gvJobs.Columns[0].Width = 40;
                gvJobs.Columns[0].HeaderCell.Value = "Nr.";
                gvJobs.Columns[1].HeaderCell.Value = "Software";
                gvJobs.Columns[2].HeaderCell.Value = "Druck ID";
                gvJobs.Columns[2].Width = 100;
                gvJobs.Columns[3].HeaderCell.Value = "Material";
                gvJobs.Columns[3].Width = 180;
                gvJobs.Columns[4].HeaderCell.Value = "Druck Gewicht[g]";
                gvJobs.Columns[4].Width = 140;
                gvJobs.Columns[5].HeaderCell.Value = "Beschreibung";

                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                sqlCon.Close();
            }

        }

        private void gvFi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtGenBarcode.Text = gvFi.SelectedRows[0].Cells[1].Value.ToString();
            cbFactory.Text = gvFi.SelectedRows[0].Cells[2].Value.ToString();
            txtColor.Text = gvFi.SelectedRows[0].Cells[3].Value.ToString();
            txtNetto.Text = gvFi.SelectedRows[0].Cells[4].Value.ToString();
            txtBrutto.Text = gvFi.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnFilaDelete_Click(object sender, EventArgs e)
        {
            sqlCon.Open();
            string query = "DELETE FROM filament WHERE Barcode='" + txtGenBarcode.Text + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, sqlCon);
            SDA.SelectCommand.ExecuteNonQuery();
            sqlCon.Close();
            DataGridFilament();
        }

        private void btnAddPrintJob_Click(object sender, EventArgs e)
        {
            if(txtPrintWeight.Text == "" || txtPrintID.Text == "")
            {
                MetroMessageBox.Show(this, "Es wurde nicht alles ausgefüllt", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                subFilamentWeight(txtPrintWeight.Text, (int)cbMaterial.SelectedValue);
                addPrintJob((int)cbPrintOs.SelectedValue, txtPrintID.Text, (int)cbMaterial.SelectedValue, txtPrintWeight.Text);
                DataGridPrintJob();
                DataGridFilament();
            }
        }

        private void subFilamentWeight(string weight, int ID)
        {
            sqlCon.Open();
            string query = "UPDATE filament SET netto = netto - "+weight+" WHERE id = "+ID+"";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, sqlCon);
            SDA.SelectCommand.ExecuteNonQuery();
            sqlCon.Close();
        }

        private void addPrintJob(int printOsID, string printID, int materialID, string printWeight)
        {
            sqlCon.Open();
            string query = "INSERT INTO printJobs (printOsID, printID, materialID, printWeight, jobTime) VALUES ('" + printOsID + "','" + printID + "','" + materialID+ "','" + printWeight + "','" + Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss") + "')";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, sqlCon);
            SDA.SelectCommand.ExecuteNonQuery();
            sqlCon.Close();
        }
    }
}
