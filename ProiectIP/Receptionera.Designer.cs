
namespace ProiectIP
{
    partial class Receptionera
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
            this.tabControlReceptionera = new System.Windows.Forms.TabControl();
            this.tabPageCamereOcupate = new System.Windows.Forms.TabPage();
            this.butonAfisareOcupate = new System.Windows.Forms.Button();
            this.dataGridViewCamereOcupate = new System.Windows.Forms.DataGridView();
            this.tabPageCamereDisponibile = new System.Windows.Forms.TabPage();
            this.butonAfisareDisponibile = new System.Windows.Forms.Button();
            this.dataGridViewCamereDisponibile = new System.Windows.Forms.DataGridView();
            this.tabPageInserareRezervare = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxIDCamera = new System.Windows.Forms.ComboBox();
            this.checkBoxTelefonFix = new System.Windows.Forms.CheckBox();
            this.checkBoxParcare = new System.Windows.Forms.CheckBox();
            this.checkBoxUscatorPar = new System.Windows.Forms.CheckBox();
            this.checkBoxInternet = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextDataDecazare = new System.Windows.Forms.RichTextBox();
            this.richTextDataCazare = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPrenume = new System.Windows.Forms.RichTextBox();
            this.textBoxCNP = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNume = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butonInserare = new System.Windows.Forms.Button();
            this.tabPageAfisareRezervari = new System.Windows.Forms.TabPage();
            this.butonAfisareRezervari = new System.Windows.Forms.Button();
            this.dataGridViewRezervari = new System.Windows.Forms.DataGridView();
            this.tabPageStergere = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxStergereIdRezervare = new System.Windows.Forms.ComboBox();
            this.butonStergereRezervare = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.butonInapoi = new System.Windows.Forms.Button();
            this.tabControlReceptionera.SuspendLayout();
            this.tabPageCamereOcupate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCamereOcupate)).BeginInit();
            this.tabPageCamereDisponibile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCamereDisponibile)).BeginInit();
            this.tabPageInserareRezervare.SuspendLayout();
            this.tabPageAfisareRezervari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezervari)).BeginInit();
            this.tabPageStergere.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlReceptionera
            // 
            this.tabControlReceptionera.Controls.Add(this.tabPageCamereOcupate);
            this.tabControlReceptionera.Controls.Add(this.tabPageCamereDisponibile);
            this.tabControlReceptionera.Controls.Add(this.tabPageInserareRezervare);
            this.tabControlReceptionera.Controls.Add(this.tabPageAfisareRezervari);
            this.tabControlReceptionera.Controls.Add(this.tabPageStergere);
            this.tabControlReceptionera.Location = new System.Drawing.Point(190, 10);
            this.tabControlReceptionera.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlReceptionera.Name = "tabControlReceptionera";
            this.tabControlReceptionera.SelectedIndex = 0;
            this.tabControlReceptionera.Size = new System.Drawing.Size(646, 432);
            this.tabControlReceptionera.TabIndex = 12;
            // 
            // tabPageCamereOcupate
            // 
            this.tabPageCamereOcupate.Controls.Add(this.butonAfisareOcupate);
            this.tabPageCamereOcupate.Controls.Add(this.dataGridViewCamereOcupate);
            this.tabPageCamereOcupate.Location = new System.Drawing.Point(4, 22);
            this.tabPageCamereOcupate.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageCamereOcupate.Name = "tabPageCamereOcupate";
            this.tabPageCamereOcupate.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageCamereOcupate.Size = new System.Drawing.Size(638, 406);
            this.tabPageCamereOcupate.TabIndex = 0;
            this.tabPageCamereOcupate.Text = "Camere ocupate";
            this.tabPageCamereOcupate.UseVisualStyleBackColor = true;
            // 
            // butonAfisareOcupate
            // 
            this.butonAfisareOcupate.BackColor = System.Drawing.Color.Maroon;
            this.butonAfisareOcupate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonAfisareOcupate.ForeColor = System.Drawing.Color.White;
            this.butonAfisareOcupate.Location = new System.Drawing.Point(538, 364);
            this.butonAfisareOcupate.Margin = new System.Windows.Forms.Padding(2);
            this.butonAfisareOcupate.Name = "butonAfisareOcupate";
            this.butonAfisareOcupate.Size = new System.Drawing.Size(97, 37);
            this.butonAfisareOcupate.TabIndex = 1;
            this.butonAfisareOcupate.Text = "Afișare";
            this.butonAfisareOcupate.UseVisualStyleBackColor = false;
            this.butonAfisareOcupate.Click += new System.EventHandler(this.butonAfisareOcupate_Click);
            // 
            // dataGridViewCamereOcupate
            // 
            this.dataGridViewCamereOcupate.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewCamereOcupate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCamereOcupate.Location = new System.Drawing.Point(10, 4);
            this.dataGridViewCamereOcupate.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewCamereOcupate.Name = "dataGridViewCamereOcupate";
            this.dataGridViewCamereOcupate.RowHeadersWidth = 51;
            this.dataGridViewCamereOcupate.RowTemplate.Height = 24;
            this.dataGridViewCamereOcupate.Size = new System.Drawing.Size(624, 358);
            this.dataGridViewCamereOcupate.TabIndex = 2;
            // 
            // tabPageCamereDisponibile
            // 
            this.tabPageCamereDisponibile.Controls.Add(this.butonAfisareDisponibile);
            this.tabPageCamereDisponibile.Controls.Add(this.dataGridViewCamereDisponibile);
            this.tabPageCamereDisponibile.Location = new System.Drawing.Point(4, 22);
            this.tabPageCamereDisponibile.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageCamereDisponibile.Name = "tabPageCamereDisponibile";
            this.tabPageCamereDisponibile.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageCamereDisponibile.Size = new System.Drawing.Size(638, 406);
            this.tabPageCamereDisponibile.TabIndex = 1;
            this.tabPageCamereDisponibile.Text = "Camere disponibile";
            this.tabPageCamereDisponibile.UseVisualStyleBackColor = true;
            // 
            // butonAfisareDisponibile
            // 
            this.butonAfisareDisponibile.BackColor = System.Drawing.Color.Maroon;
            this.butonAfisareDisponibile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonAfisareDisponibile.ForeColor = System.Drawing.Color.White;
            this.butonAfisareDisponibile.Location = new System.Drawing.Point(537, 369);
            this.butonAfisareDisponibile.Margin = new System.Windows.Forms.Padding(2);
            this.butonAfisareDisponibile.Name = "butonAfisareDisponibile";
            this.butonAfisareDisponibile.Size = new System.Drawing.Size(97, 37);
            this.butonAfisareDisponibile.TabIndex = 3;
            this.butonAfisareDisponibile.Text = "Afișare";
            this.butonAfisareDisponibile.UseVisualStyleBackColor = false;
            this.butonAfisareDisponibile.Click += new System.EventHandler(this.butonAfisareDisponibile_Click);
            // 
            // dataGridViewCamereDisponibile
            // 
            this.dataGridViewCamereDisponibile.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewCamereDisponibile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCamereDisponibile.Location = new System.Drawing.Point(4, 5);
            this.dataGridViewCamereDisponibile.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewCamereDisponibile.Name = "dataGridViewCamereDisponibile";
            this.dataGridViewCamereDisponibile.RowHeadersWidth = 51;
            this.dataGridViewCamereDisponibile.RowTemplate.Height = 24;
            this.dataGridViewCamereDisponibile.Size = new System.Drawing.Size(630, 358);
            this.dataGridViewCamereDisponibile.TabIndex = 4;
            // 
            // tabPageInserareRezervare
            // 
            this.tabPageInserareRezervare.Controls.Add(this.label8);
            this.tabPageInserareRezervare.Controls.Add(this.comboBoxIDCamera);
            this.tabPageInserareRezervare.Controls.Add(this.checkBoxTelefonFix);
            this.tabPageInserareRezervare.Controls.Add(this.checkBoxParcare);
            this.tabPageInserareRezervare.Controls.Add(this.checkBoxUscatorPar);
            this.tabPageInserareRezervare.Controls.Add(this.checkBoxInternet);
            this.tabPageInserareRezervare.Controls.Add(this.label7);
            this.tabPageInserareRezervare.Controls.Add(this.label6);
            this.tabPageInserareRezervare.Controls.Add(this.richTextDataDecazare);
            this.tabPageInserareRezervare.Controls.Add(this.richTextDataCazare);
            this.tabPageInserareRezervare.Controls.Add(this.label5);
            this.tabPageInserareRezervare.Controls.Add(this.textBoxPrenume);
            this.tabPageInserareRezervare.Controls.Add(this.textBoxCNP);
            this.tabPageInserareRezervare.Controls.Add(this.label4);
            this.tabPageInserareRezervare.Controls.Add(this.textBoxNume);
            this.tabPageInserareRezervare.Controls.Add(this.label1);
            this.tabPageInserareRezervare.Controls.Add(this.butonInserare);
            this.tabPageInserareRezervare.Location = new System.Drawing.Point(4, 22);
            this.tabPageInserareRezervare.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageInserareRezervare.Name = "tabPageInserareRezervare";
            this.tabPageInserareRezervare.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageInserareRezervare.Size = new System.Drawing.Size(638, 406);
            this.tabPageInserareRezervare.TabIndex = 2;
            this.tabPageInserareRezervare.Text = "Inserare";
            this.tabPageInserareRezervare.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 51);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "ID camera";
            // 
            // comboBoxIDCamera
            // 
            this.comboBoxIDCamera.FormattingEnabled = true;
            this.comboBoxIDCamera.Location = new System.Drawing.Point(80, 51);
            this.comboBoxIDCamera.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxIDCamera.Name = "comboBoxIDCamera";
            this.comboBoxIDCamera.Size = new System.Drawing.Size(111, 21);
            this.comboBoxIDCamera.TabIndex = 26;
            // 
            // checkBoxTelefonFix
            // 
            this.checkBoxTelefonFix.AutoSize = true;
            this.checkBoxTelefonFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTelefonFix.Location = new System.Drawing.Point(80, 233);
            this.checkBoxTelefonFix.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxTelefonFix.Name = "checkBoxTelefonFix";
            this.checkBoxTelefonFix.Size = new System.Drawing.Size(92, 21);
            this.checkBoxTelefonFix.TabIndex = 24;
            this.checkBoxTelefonFix.Text = "Telefon fix";
            this.checkBoxTelefonFix.UseVisualStyleBackColor = true;
            // 
            // checkBoxParcare
            // 
            this.checkBoxParcare.AutoSize = true;
            this.checkBoxParcare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxParcare.Location = new System.Drawing.Point(392, 277);
            this.checkBoxParcare.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxParcare.Name = "checkBoxParcare";
            this.checkBoxParcare.Size = new System.Drawing.Size(77, 21);
            this.checkBoxParcare.TabIndex = 23;
            this.checkBoxParcare.Text = "Parcare";
            this.checkBoxParcare.UseVisualStyleBackColor = true;
            // 
            // checkBoxUscatorPar
            // 
            this.checkBoxUscatorPar.AutoSize = true;
            this.checkBoxUscatorPar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUscatorPar.Location = new System.Drawing.Point(80, 277);
            this.checkBoxUscatorPar.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxUscatorPar.Name = "checkBoxUscatorPar";
            this.checkBoxUscatorPar.Size = new System.Drawing.Size(101, 21);
            this.checkBoxUscatorPar.TabIndex = 22;
            this.checkBoxUscatorPar.Text = "Uscător păr";
            this.checkBoxUscatorPar.UseVisualStyleBackColor = true;
            // 
            // checkBoxInternet
            // 
            this.checkBoxInternet.AutoSize = true;
            this.checkBoxInternet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxInternet.Location = new System.Drawing.Point(394, 233);
            this.checkBoxInternet.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxInternet.Name = "checkBoxInternet";
            this.checkBoxInternet.Size = new System.Drawing.Size(75, 21);
            this.checkBoxInternet.TabIndex = 21;
            this.checkBoxInternet.Text = "Internet";
            this.checkBoxInternet.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(290, 97);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Data cazare";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(290, 145);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Data decazare";
            // 
            // richTextDataDecazare
            // 
            this.richTextDataDecazare.Location = new System.Drawing.Point(394, 138);
            this.richTextDataDecazare.Margin = new System.Windows.Forms.Padding(2);
            this.richTextDataDecazare.Name = "richTextDataDecazare";
            this.richTextDataDecazare.Size = new System.Drawing.Size(111, 24);
            this.richTextDataDecazare.TabIndex = 18;
            this.richTextDataDecazare.Text = "";
            // 
            // richTextDataCazare
            // 
            this.richTextDataCazare.Location = new System.Drawing.Point(392, 90);
            this.richTextDataCazare.Margin = new System.Windows.Forms.Padding(2);
            this.richTextDataCazare.Name = "richTextDataCazare";
            this.richTextDataCazare.Size = new System.Drawing.Size(111, 24);
            this.richTextDataCazare.TabIndex = 17;
            this.richTextDataCazare.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nume";
            // 
            // textBoxPrenume
            // 
            this.textBoxPrenume.Location = new System.Drawing.Point(80, 138);
            this.textBoxPrenume.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPrenume.Name = "textBoxPrenume";
            this.textBoxPrenume.Size = new System.Drawing.Size(111, 24);
            this.textBoxPrenume.TabIndex = 13;
            this.textBoxPrenume.Text = "";
            // 
            // textBoxCNP
            // 
            this.textBoxCNP.Location = new System.Drawing.Point(392, 51);
            this.textBoxCNP.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCNP.Name = "textBoxCNP";
            this.textBoxCNP.Size = new System.Drawing.Size(111, 24);
            this.textBoxCNP.TabIndex = 12;
            this.textBoxCNP.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(290, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "CNP";
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(80, 90);
            this.textBoxNume.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(111, 24);
            this.textBoxNume.TabIndex = 8;
            this.textBoxNume.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Prenume";
            // 
            // butonInserare
            // 
            this.butonInserare.BackColor = System.Drawing.Color.Maroon;
            this.butonInserare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonInserare.ForeColor = System.Drawing.Color.White;
            this.butonInserare.Location = new System.Drawing.Point(408, 352);
            this.butonInserare.Margin = new System.Windows.Forms.Padding(2);
            this.butonInserare.Name = "butonInserare";
            this.butonInserare.Size = new System.Drawing.Size(97, 37);
            this.butonInserare.TabIndex = 4;
            this.butonInserare.Text = "Inserare";
            this.butonInserare.UseVisualStyleBackColor = false;
            this.butonInserare.Click += new System.EventHandler(this.butonInserareRezervare_Click);
            // 
            // tabPageAfisareRezervari
            // 
            this.tabPageAfisareRezervari.Controls.Add(this.butonAfisareRezervari);
            this.tabPageAfisareRezervari.Controls.Add(this.dataGridViewRezervari);
            this.tabPageAfisareRezervari.Location = new System.Drawing.Point(4, 22);
            this.tabPageAfisareRezervari.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageAfisareRezervari.Name = "tabPageAfisareRezervari";
            this.tabPageAfisareRezervari.Size = new System.Drawing.Size(638, 406);
            this.tabPageAfisareRezervari.TabIndex = 3;
            this.tabPageAfisareRezervari.Text = "Rezervari";
            this.tabPageAfisareRezervari.UseVisualStyleBackColor = true;
            // 
            // butonAfisareRezervari
            // 
            this.butonAfisareRezervari.BackColor = System.Drawing.Color.Maroon;
            this.butonAfisareRezervari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonAfisareRezervari.ForeColor = System.Drawing.Color.White;
            this.butonAfisareRezervari.Location = new System.Drawing.Point(534, 367);
            this.butonAfisareRezervari.Margin = new System.Windows.Forms.Padding(2);
            this.butonAfisareRezervari.Name = "butonAfisareRezervari";
            this.butonAfisareRezervari.Size = new System.Drawing.Size(97, 37);
            this.butonAfisareRezervari.TabIndex = 3;
            this.butonAfisareRezervari.Text = "Afișare";
            this.butonAfisareRezervari.UseVisualStyleBackColor = false;
            this.butonAfisareRezervari.Click += new System.EventHandler(this.butonAfisare_Click);
            // 
            // dataGridViewRezervari
            // 
            this.dataGridViewRezervari.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewRezervari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRezervari.Location = new System.Drawing.Point(4, 5);
            this.dataGridViewRezervari.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewRezervari.Name = "dataGridViewRezervari";
            this.dataGridViewRezervari.RowHeadersWidth = 51;
            this.dataGridViewRezervari.RowTemplate.Height = 24;
            this.dataGridViewRezervari.Size = new System.Drawing.Size(627, 358);
            this.dataGridViewRezervari.TabIndex = 4;
            // 
            // tabPageStergere
            // 
            this.tabPageStergere.Controls.Add(this.label9);
            this.tabPageStergere.Controls.Add(this.comboBoxStergereIdRezervare);
            this.tabPageStergere.Controls.Add(this.butonStergereRezervare);
            this.tabPageStergere.Location = new System.Drawing.Point(4, 22);
            this.tabPageStergere.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageStergere.Name = "tabPageStergere";
            this.tabPageStergere.Size = new System.Drawing.Size(638, 406);
            this.tabPageStergere.TabIndex = 4;
            this.tabPageStergere.Text = "Ștergere";
            this.tabPageStergere.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(162, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Ștergere rezervare";
            // 
            // comboBoxStergereIdRezervare
            // 
            this.comboBoxStergereIdRezervare.FormattingEnabled = true;
            this.comboBoxStergereIdRezervare.Location = new System.Drawing.Point(294, 25);
            this.comboBoxStergereIdRezervare.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxStergereIdRezervare.Name = "comboBoxStergereIdRezervare";
            this.comboBoxStergereIdRezervare.Size = new System.Drawing.Size(92, 21);
            this.comboBoxStergereIdRezervare.TabIndex = 6;
            // 
            // butonStergereRezervare
            // 
            this.butonStergereRezervare.BackColor = System.Drawing.Color.Maroon;
            this.butonStergereRezervare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonStergereRezervare.ForeColor = System.Drawing.Color.White;
            this.butonStergereRezervare.Location = new System.Drawing.Point(237, 72);
            this.butonStergereRezervare.Margin = new System.Windows.Forms.Padding(2);
            this.butonStergereRezervare.Name = "butonStergereRezervare";
            this.butonStergereRezervare.Size = new System.Drawing.Size(97, 37);
            this.butonStergereRezervare.TabIndex = 5;
            this.butonStergereRezervare.Text = "Ștergere";
            this.butonStergereRezervare.UseVisualStyleBackColor = false;
            this.butonStergereRezervare.Click += new System.EventHandler(this.butonStergereRezervare_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Maroon;
            this.groupBox1.Controls.Add(this.buttonExit);
            this.groupBox1.Controls.Add(this.butonInapoi);
            this.groupBox1.Location = new System.Drawing.Point(-3, -8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(189, 461);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Maroon;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExit.Location = new System.Drawing.Point(4, 19);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(181, 41);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // butonInapoi
            // 
            this.butonInapoi.BackColor = System.Drawing.Color.Maroon;
            this.butonInapoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonInapoi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butonInapoi.Location = new System.Drawing.Point(4, 409);
            this.butonInapoi.Margin = new System.Windows.Forms.Padding(2);
            this.butonInapoi.Name = "butonInapoi";
            this.butonInapoi.Size = new System.Drawing.Size(184, 41);
            this.butonInapoi.TabIndex = 10;
            this.butonInapoi.Text = "<";
            this.butonInapoi.UseVisualStyleBackColor = false;
            this.butonInapoi.Click += new System.EventHandler(this.butonInapoi_Click);
            // 
            // Receptionera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 444);
            this.Controls.Add(this.tabControlReceptionera);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Receptionera";
            this.Text = "Receptionera";
            this.tabControlReceptionera.ResumeLayout(false);
            this.tabPageCamereOcupate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCamereOcupate)).EndInit();
            this.tabPageCamereDisponibile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCamereDisponibile)).EndInit();
            this.tabPageInserareRezervare.ResumeLayout(false);
            this.tabPageInserareRezervare.PerformLayout();
            this.tabPageAfisareRezervari.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezervari)).EndInit();
            this.tabPageStergere.ResumeLayout(false);
            this.tabPageStergere.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlReceptionera;
        private System.Windows.Forms.TabPage tabPageCamereOcupate;
        private System.Windows.Forms.Button butonAfisareOcupate;
        private System.Windows.Forms.DataGridView dataGridViewCamereOcupate;
        private System.Windows.Forms.TabPage tabPageCamereDisponibile;
        private System.Windows.Forms.Button butonAfisareDisponibile;
        private System.Windows.Forms.DataGridView dataGridViewCamereDisponibile;
        private System.Windows.Forms.TabPage tabPageInserareRezervare;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox textBoxPrenume;
        private System.Windows.Forms.RichTextBox textBoxCNP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox textBoxNume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butonInserare;
        private System.Windows.Forms.TabPage tabPageAfisareRezervari;
        private System.Windows.Forms.Button butonAfisareRezervari;
        private System.Windows.Forms.DataGridView dataGridViewRezervari;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butonInapoi;
        private System.Windows.Forms.TabPage tabPageStergere;
        private System.Windows.Forms.Button butonStergereRezervare;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxIDCamera;
        private System.Windows.Forms.CheckBox checkBoxTelefonFix;
        private System.Windows.Forms.CheckBox checkBoxParcare;
        private System.Windows.Forms.CheckBox checkBoxUscatorPar;
        private System.Windows.Forms.CheckBox checkBoxInternet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextDataDecazare;
        private System.Windows.Forms.RichTextBox richTextDataCazare;
        private System.Windows.Forms.ComboBox comboBoxStergereIdRezervare;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonExit;
    }
}