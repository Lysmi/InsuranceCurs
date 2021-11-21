
namespace InsuranceCurs
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageClients = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteClient = new System.Windows.Forms.Button();
            this.addElem = new System.Windows.Forms.Button();
            this.clientDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPageContracts = new System.Windows.Forms.TabPage();
            this.contractsDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPageWorkers = new System.Windows.Forms.TabPage();
            this.workersDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPageCity = new System.Windows.Forms.TabPage();
            this.citiesDataGridView = new System.Windows.Forms.DataGridView();
            this.Office = new System.Windows.Forms.TabPage();
            this.officeDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPageBranch = new System.Windows.Forms.TabPage();
            this.branchDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPageLicense = new System.Windows.Forms.TabPage();
            this.licenseDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPageInsVariant = new System.Windows.Forms.TabPage();
            this.insVariantDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPageTypeProperty = new System.Windows.Forms.TabPage();
            this.typePropDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPageSocial = new System.Windows.Forms.TabPage();
            this.SocialDataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPageClients.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).BeginInit();
            this.tabPageContracts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractsDataGridView)).BeginInit();
            this.tabPageWorkers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workersDataGridView)).BeginInit();
            this.tabPageCity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.citiesDataGridView)).BeginInit();
            this.Office.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officeDataGridView)).BeginInit();
            this.tabPageBranch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchDataGridView)).BeginInit();
            this.tabPageLicense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.licenseDataGridView)).BeginInit();
            this.tabPageInsVariant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insVariantDataGridView)).BeginInit();
            this.tabPageTypeProperty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typePropDataGridView)).BeginInit();
            this.tabPageSocial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SocialDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageClients);
            this.tabControl1.Controls.Add(this.tabPageContracts);
            this.tabControl1.Controls.Add(this.tabPageWorkers);
            this.tabControl1.Controls.Add(this.tabPageCity);
            this.tabControl1.Controls.Add(this.Office);
            this.tabControl1.Controls.Add(this.tabPageBranch);
            this.tabControl1.Controls.Add(this.tabPageLicense);
            this.tabControl1.Controls.Add(this.tabPageInsVariant);
            this.tabControl1.Controls.Add(this.tabPageTypeProperty);
            this.tabControl1.Controls.Add(this.tabPageSocial);
            this.tabControl1.Location = new System.Drawing.Point(5, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1200, 650);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageClients
            // 
            this.tabPageClients.BackColor = System.Drawing.Color.White;
            this.tabPageClients.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageClients.Controls.Add(this.groupBox1);
            this.tabPageClients.Controls.Add(this.clientDataGridView);
            this.tabPageClients.Location = new System.Drawing.Point(4, 22);
            this.tabPageClients.Name = "tabPageClients";
            this.tabPageClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClients.Size = new System.Drawing.Size(1192, 624);
            this.tabPageClients.TabIndex = 0;
            this.tabPageClients.Text = "Клиенты";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteClient);
            this.groupBox1.Controls.Add(this.addElem);
            this.groupBox1.Location = new System.Drawing.Point(7, 562);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1175, 52);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // deleteClient
            // 
            this.deleteClient.Location = new System.Drawing.Point(200, 10);
            this.deleteClient.Name = "deleteClient";
            this.deleteClient.Size = new System.Drawing.Size(188, 36);
            this.deleteClient.TabIndex = 1;
            this.deleteClient.Text = "Удалить элемент";
            this.deleteClient.UseVisualStyleBackColor = true;
            this.deleteClient.Click += new System.EventHandler(this.deleteClient_Click);
            // 
            // addElem
            // 
            this.addElem.Location = new System.Drawing.Point(6, 10);
            this.addElem.Name = "addElem";
            this.addElem.Size = new System.Drawing.Size(188, 36);
            this.addElem.TabIndex = 0;
            this.addElem.Text = "Добавить элемент";
            this.addElem.UseVisualStyleBackColor = true;
            this.addElem.Click += new System.EventHandler(this.addElem_Click);
            // 
            // clientDataGridView
            // 
            this.clientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientDataGridView.Location = new System.Drawing.Point(5, 5);
            this.clientDataGridView.Name = "clientDataGridView";
            this.clientDataGridView.ReadOnly = true;
            this.clientDataGridView.Size = new System.Drawing.Size(1180, 550);
            this.clientDataGridView.TabIndex = 0;
            // 
            // tabPageContracts
            // 
            this.tabPageContracts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageContracts.Controls.Add(this.contractsDataGridView);
            this.tabPageContracts.Location = new System.Drawing.Point(4, 22);
            this.tabPageContracts.Name = "tabPageContracts";
            this.tabPageContracts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageContracts.Size = new System.Drawing.Size(1192, 624);
            this.tabPageContracts.TabIndex = 1;
            this.tabPageContracts.Text = "Договора";
            this.tabPageContracts.UseVisualStyleBackColor = true;
            // 
            // contractsDataGridView
            // 
            this.contractsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contractsDataGridView.Location = new System.Drawing.Point(5, 5);
            this.contractsDataGridView.Name = "contractsDataGridView";
            this.contractsDataGridView.ReadOnly = true;
            this.contractsDataGridView.Size = new System.Drawing.Size(1180, 550);
            this.contractsDataGridView.TabIndex = 1;
            // 
            // tabPageWorkers
            // 
            this.tabPageWorkers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageWorkers.Controls.Add(this.workersDataGridView);
            this.tabPageWorkers.Location = new System.Drawing.Point(4, 22);
            this.tabPageWorkers.Name = "tabPageWorkers";
            this.tabPageWorkers.Size = new System.Drawing.Size(1192, 624);
            this.tabPageWorkers.TabIndex = 2;
            this.tabPageWorkers.Text = "Сотрудники";
            this.tabPageWorkers.UseVisualStyleBackColor = true;
            // 
            // workersDataGridView
            // 
            this.workersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workersDataGridView.Location = new System.Drawing.Point(5, 5);
            this.workersDataGridView.Name = "workersDataGridView";
            this.workersDataGridView.ReadOnly = true;
            this.workersDataGridView.Size = new System.Drawing.Size(1180, 550);
            this.workersDataGridView.TabIndex = 2;
            // 
            // tabPageCity
            // 
            this.tabPageCity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageCity.Controls.Add(this.citiesDataGridView);
            this.tabPageCity.Location = new System.Drawing.Point(4, 22);
            this.tabPageCity.Name = "tabPageCity";
            this.tabPageCity.Size = new System.Drawing.Size(1192, 624);
            this.tabPageCity.TabIndex = 3;
            this.tabPageCity.Text = "Города";
            this.tabPageCity.UseVisualStyleBackColor = true;
            // 
            // citiesDataGridView
            // 
            this.citiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.citiesDataGridView.Location = new System.Drawing.Point(5, 5);
            this.citiesDataGridView.Name = "citiesDataGridView";
            this.citiesDataGridView.ReadOnly = true;
            this.citiesDataGridView.Size = new System.Drawing.Size(1180, 550);
            this.citiesDataGridView.TabIndex = 2;
            // 
            // Office
            // 
            this.Office.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Office.Controls.Add(this.officeDataGridView);
            this.Office.Location = new System.Drawing.Point(4, 22);
            this.Office.Name = "Office";
            this.Office.Size = new System.Drawing.Size(1192, 624);
            this.Office.TabIndex = 4;
            this.Office.Text = "Главные офисы";
            this.Office.UseVisualStyleBackColor = true;
            // 
            // officeDataGridView
            // 
            this.officeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.officeDataGridView.Location = new System.Drawing.Point(5, 5);
            this.officeDataGridView.Name = "officeDataGridView";
            this.officeDataGridView.ReadOnly = true;
            this.officeDataGridView.Size = new System.Drawing.Size(1180, 550);
            this.officeDataGridView.TabIndex = 2;
            // 
            // tabPageBranch
            // 
            this.tabPageBranch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageBranch.Controls.Add(this.branchDataGridView);
            this.tabPageBranch.Location = new System.Drawing.Point(4, 22);
            this.tabPageBranch.Name = "tabPageBranch";
            this.tabPageBranch.Size = new System.Drawing.Size(1192, 624);
            this.tabPageBranch.TabIndex = 5;
            this.tabPageBranch.Text = "Филиалы";
            this.tabPageBranch.UseVisualStyleBackColor = true;
            // 
            // branchDataGridView
            // 
            this.branchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.branchDataGridView.Location = new System.Drawing.Point(5, 5);
            this.branchDataGridView.Name = "branchDataGridView";
            this.branchDataGridView.ReadOnly = true;
            this.branchDataGridView.Size = new System.Drawing.Size(1180, 550);
            this.branchDataGridView.TabIndex = 2;
            // 
            // tabPageLicense
            // 
            this.tabPageLicense.BackColor = System.Drawing.Color.Transparent;
            this.tabPageLicense.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageLicense.Controls.Add(this.licenseDataGridView);
            this.tabPageLicense.Location = new System.Drawing.Point(4, 22);
            this.tabPageLicense.Name = "tabPageLicense";
            this.tabPageLicense.Size = new System.Drawing.Size(1192, 624);
            this.tabPageLicense.TabIndex = 6;
            this.tabPageLicense.Text = "Лицензии";
            // 
            // licenseDataGridView
            // 
            this.licenseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.licenseDataGridView.Location = new System.Drawing.Point(5, 5);
            this.licenseDataGridView.Name = "licenseDataGridView";
            this.licenseDataGridView.ReadOnly = true;
            this.licenseDataGridView.Size = new System.Drawing.Size(1080, 550);
            this.licenseDataGridView.TabIndex = 2;
            // 
            // tabPageInsVariant
            // 
            this.tabPageInsVariant.Controls.Add(this.insVariantDataGridView);
            this.tabPageInsVariant.Location = new System.Drawing.Point(4, 22);
            this.tabPageInsVariant.Name = "tabPageInsVariant";
            this.tabPageInsVariant.Size = new System.Drawing.Size(1192, 624);
            this.tabPageInsVariant.TabIndex = 7;
            this.tabPageInsVariant.Text = "Виды страхования";
            this.tabPageInsVariant.UseVisualStyleBackColor = true;
            // 
            // insVariantDataGridView
            // 
            this.insVariantDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.insVariantDataGridView.Location = new System.Drawing.Point(5, 5);
            this.insVariantDataGridView.Name = "insVariantDataGridView";
            this.insVariantDataGridView.ReadOnly = true;
            this.insVariantDataGridView.Size = new System.Drawing.Size(1180, 550);
            this.insVariantDataGridView.TabIndex = 3;
            // 
            // tabPageTypeProperty
            // 
            this.tabPageTypeProperty.Controls.Add(this.typePropDataGridView);
            this.tabPageTypeProperty.Location = new System.Drawing.Point(4, 22);
            this.tabPageTypeProperty.Name = "tabPageTypeProperty";
            this.tabPageTypeProperty.Size = new System.Drawing.Size(1192, 624);
            this.tabPageTypeProperty.TabIndex = 8;
            this.tabPageTypeProperty.Text = "Виды собственности";
            this.tabPageTypeProperty.UseVisualStyleBackColor = true;
            // 
            // typePropDataGridView
            // 
            this.typePropDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.typePropDataGridView.Location = new System.Drawing.Point(5, 5);
            this.typePropDataGridView.Name = "typePropDataGridView";
            this.typePropDataGridView.ReadOnly = true;
            this.typePropDataGridView.Size = new System.Drawing.Size(1180, 550);
            this.typePropDataGridView.TabIndex = 3;
            // 
            // tabPageSocial
            // 
            this.tabPageSocial.Controls.Add(this.SocialDataGridView);
            this.tabPageSocial.Location = new System.Drawing.Point(4, 22);
            this.tabPageSocial.Name = "tabPageSocial";
            this.tabPageSocial.Size = new System.Drawing.Size(1192, 624);
            this.tabPageSocial.TabIndex = 9;
            this.tabPageSocial.Text = "Социальное положение";
            this.tabPageSocial.UseVisualStyleBackColor = true;
            // 
            // SocialDataGridView
            // 
            this.SocialDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SocialDataGridView.Location = new System.Drawing.Point(5, 5);
            this.SocialDataGridView.Name = "SocialDataGridView";
            this.SocialDataGridView.ReadOnly = true;
            this.SocialDataGridView.Size = new System.Drawing.Size(1180, 550);
            this.SocialDataGridView.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 712);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageClients.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).EndInit();
            this.tabPageContracts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contractsDataGridView)).EndInit();
            this.tabPageWorkers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.workersDataGridView)).EndInit();
            this.tabPageCity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.citiesDataGridView)).EndInit();
            this.Office.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.officeDataGridView)).EndInit();
            this.tabPageBranch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.branchDataGridView)).EndInit();
            this.tabPageLicense.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.licenseDataGridView)).EndInit();
            this.tabPageInsVariant.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.insVariantDataGridView)).EndInit();
            this.tabPageTypeProperty.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.typePropDataGridView)).EndInit();
            this.tabPageSocial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SocialDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageClients;
        private System.Windows.Forms.TabPage tabPageContracts;
        private System.Windows.Forms.TabPage tabPageWorkers;
        private System.Windows.Forms.TabPage tabPageCity;
        private System.Windows.Forms.TabPage Office;
        private System.Windows.Forms.TabPage tabPageBranch;
        private System.Windows.Forms.TabPage tabPageLicense;
        private System.Windows.Forms.DataGridView clientDataGridView;
        private System.Windows.Forms.DataGridView contractsDataGridView;
        private System.Windows.Forms.DataGridView workersDataGridView;
        private System.Windows.Forms.DataGridView citiesDataGridView;
        private System.Windows.Forms.DataGridView officeDataGridView;
        private System.Windows.Forms.DataGridView branchDataGridView;
        private System.Windows.Forms.DataGridView licenseDataGridView;
        private System.Windows.Forms.TabPage tabPageInsVariant;
        private System.Windows.Forms.DataGridView insVariantDataGridView;
        private System.Windows.Forms.TabPage tabPageTypeProperty;
        private System.Windows.Forms.DataGridView typePropDataGridView;
        private System.Windows.Forms.TabPage tabPageSocial;
        private System.Windows.Forms.DataGridView SocialDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteClient;
        private System.Windows.Forms.Button addElem;
    }
}

