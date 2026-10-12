namespace PostServiceFormsApp.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TextBox txtServerUrl;
        private System.Windows.Forms.DataGridView dgvPostings;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblCount;

        // Колонки DataGridView
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeliveryType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDimensions;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle cellStyleNumber = new System.Windows.Forms.DataGridViewCellStyle();
            cellStyleNumber.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblServer = new System.Windows.Forms.Label();
            this.txtServerUrl = new System.Windows.Forms.TextBox();
            this.dgvPostings = new System.Windows.Forms.DataGridView();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCount = new System.Windows.Forms.ToolStripStatusLabel();

            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeliveryType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDimensions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.pnlHeader.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostings)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(0, 90, 158);
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(960, 50);

            // lblHeaderTitle
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(16, 12);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(420, 25);
            this.lblHeaderTitle.Text = "📦 Облік поштових відправлень — PostService";

            // pnlToolbar
            this.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.pnlToolbar.Controls.Add(this.btnAdd);
            this.pnlToolbar.Controls.Add(this.btnEdit);
            this.pnlToolbar.Controls.Add(this.btnDelete);
            this.pnlToolbar.Controls.Add(this.btnRefresh);
            this.pnlToolbar.Controls.Add(this.lblServer);
            this.pnlToolbar.Controls.Add(this.txtServerUrl);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 50);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(960, 48);

            // btnAdd
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(16, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 32);
            this.btnAdd.Text = "➕ Створити нове";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnEdit
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(150, 8);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 32);
            this.btnEdit.Text = "✏️ Редагувати";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            // btnDelete
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnDelete.Location = new System.Drawing.Point(268, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 32);
            this.btnDelete.Text = "🗑️ Видалити";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // btnRefresh
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(376, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(95, 32);
            this.btnRefresh.Text = "🔄 Оновити";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // lblServer
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(530, 16);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(85, 15);
            this.lblServer.Text = "REST API Сервер:";

            // txtServerUrl
            this.txtServerUrl.Location = new System.Drawing.Point(620, 13);
            this.txtServerUrl.Name = "txtServerUrl";
            this.txtServerUrl.Size = new System.Drawing.Size(240, 23);

            // dgvPostings
            this.dgvPostings.AllowUserToAddRows = false;
            this.dgvPostings.AllowUserToDeleteRows = false;
            this.dgvPostings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPostings.BackgroundColor = System.Drawing.Color.White;
            this.dgvPostings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPostings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPostings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colId,
                this.colContent,
                this.colFrom,
                this.colTo,
                this.colDeliveryType,
                this.colWeight,
                this.colDimensions,
                this.colValue,
                this.colPrice
            });
            this.dgvPostings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPostings.Location = new System.Drawing.Point(0, 98);
            this.dgvPostings.MultiSelect = false;
            this.dgvPostings.Name = "dgvPostings";
            this.dgvPostings.ReadOnly = true;
            this.dgvPostings.RowHeadersVisible = false;
            this.dgvPostings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPostings.Size = new System.Drawing.Size(960, 420);
            this.dgvPostings.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPostings_CellDoubleClick);

            // Columns setup
            this.colId.DataPropertyName = "Id";
            this.colId.FillWeight = 40F;
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";

            this.colContent.DataPropertyName = "Content";
            this.colContent.FillWeight = 120F;
            this.colContent.HeaderText = "Вміст";
            this.colContent.Name = "colContent";

            this.colFrom.DataPropertyName = "From";
            this.colFrom.FillWeight = 85F;
            this.colFrom.HeaderText = "Відправник";
            this.colFrom.Name = "colFrom";

            this.colTo.DataPropertyName = "To";
            this.colTo.FillWeight = 85F;
            this.colTo.HeaderText = "Одержувач";
            this.colTo.Name = "colTo";

            this.colDeliveryType.DataPropertyName = "DeliveryTypeName";
            this.colDeliveryType.FillWeight = 110F;
            this.colDeliveryType.HeaderText = "Тип доставки";
            this.colDeliveryType.Name = "colDeliveryType";

            this.colWeight.DataPropertyName = "Weight";
            this.colWeight.DefaultCellStyle = cellStyleNumber;
            this.colWeight.FillWeight = 60F;
            this.colWeight.HeaderText = "Вага (кг)";
            this.colWeight.Name = "colWeight";

            this.colDimensions.DataPropertyName = "DimensionsText";
            this.colDimensions.FillWeight = 95F;
            this.colDimensions.HeaderText = "Габарити";
            this.colDimensions.Name = "colDimensions";

            this.colValue.DataPropertyName = "Value";
            this.colValue.DefaultCellStyle = cellStyleNumber;
            this.colValue.FillWeight = 75F;
            this.colValue.HeaderText = "Цінність (грн)";
            this.colValue.Name = "colValue";

            this.colPrice.DataPropertyName = "Price";
            this.colPrice.DefaultCellStyle = cellStyleNumber;
            this.colPrice.FillWeight = 75F;
            this.colPrice.HeaderText = "Ціна (грн)";
            this.colPrice.Name = "colPrice";

            // statusStrip
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.lblStatus,
                this.lblCount
            });
            this.statusStrip.Location = new System.Drawing.Point(0, 518);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(960, 22);

            // lblStatus
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(810, 17);
            this.lblStatus.Spring = true;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStatus.Text = "Готово до роботи";

            // lblCount
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(100, 17);
            this.lblCount.Text = "Всього записів: 0";

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.dgvPostings);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.pnlHeader);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Облік поштових відправлень (PostService)";
            this.Load += new System.EventHandler(this.MainForm_Load);

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostings)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
