namespace PostServiceFormsApp.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

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

            this.pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostings)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();

            // pnlToolbar
            this.pnlToolbar.Controls.Add(this.btnAdd);
            this.pnlToolbar.Controls.Add(this.btnEdit);
            this.pnlToolbar.Controls.Add(this.btnDelete);
            this.pnlToolbar.Controls.Add(this.btnRefresh);
            this.pnlToolbar.Controls.Add(this.lblServer);
            this.pnlToolbar.Controls.Add(this.txtServerUrl);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(920, 45);

            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(12, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 26);
            this.btnAdd.Text = "Додати";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnEdit
            this.btnEdit.Location = new System.Drawing.Point(115, 10);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 26);
            this.btnEdit.Text = "Редагувати";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            // btnDelete
            this.btnDelete.Location = new System.Drawing.Point(218, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 26);
            this.btnDelete.Text = "Видалити";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // btnRefresh
            this.btnRefresh.Location = new System.Drawing.Point(311, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 26);
            this.btnRefresh.Text = "Оновити";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // lblServer
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(440, 15);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(57, 15);
            this.lblServer.Text = "API адреса:";

            // txtServerUrl
            this.txtServerUrl.Location = new System.Drawing.Point(505, 12);
            this.txtServerUrl.Name = "txtServerUrl";
            this.txtServerUrl.Size = new System.Drawing.Size(260, 23);

            // dgvPostings
            this.dgvPostings.AllowUserToAddRows = false;
            this.dgvPostings.AllowUserToDeleteRows = false;
            this.dgvPostings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPostings.BackgroundColor = System.Drawing.SystemColors.Window;
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
            this.dgvPostings.Location = new System.Drawing.Point(0, 45);
            this.dgvPostings.MultiSelect = false;
            this.dgvPostings.Name = "dgvPostings";
            this.dgvPostings.ReadOnly = true;
            this.dgvPostings.RowHeadersVisible = false;
            this.dgvPostings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPostings.Size = new System.Drawing.Size(920, 440);
            this.dgvPostings.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPostings_CellDoubleClick);

            // Columns
            this.colId.DataPropertyName = "Id";
            this.colId.FillWeight = 40F;
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";

            this.colContent.DataPropertyName = "Content";
            this.colContent.FillWeight = 110F;
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
            this.colDeliveryType.FillWeight = 100F;
            this.colDeliveryType.HeaderText = "Тип доставки";
            this.colDeliveryType.Name = "colDeliveryType";

            this.colWeight.DataPropertyName = "Weight";
            this.colWeight.FillWeight = 60F;
            this.colWeight.HeaderText = "Вага (кг)";
            this.colWeight.Name = "colWeight";

            this.colDimensions.DataPropertyName = "DimensionsText";
            this.colDimensions.FillWeight = 90F;
            this.colDimensions.HeaderText = "Габарити";
            this.colDimensions.Name = "colDimensions";

            this.colValue.DataPropertyName = "Value";
            this.colValue.FillWeight = 70F;
            this.colValue.HeaderText = "Цінність";
            this.colValue.Name = "colValue";

            this.colPrice.DataPropertyName = "Price";
            this.colPrice.FillWeight = 70F;
            this.colPrice.HeaderText = "Ціна";
            this.colPrice.Name = "colPrice";

            // statusStrip
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.lblStatus,
                this.lblCount
            });
            this.statusStrip.Location = new System.Drawing.Point(0, 485);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(920, 22);

            // lblStatus
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(785, 17);
            this.lblStatus.Spring = true;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStatus.Text = "Готово";

            // lblCount
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(120, 17);
            this.lblCount.Text = "Всього записів: 0";

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 507);
            this.Controls.Add(this.dgvPostings);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.pnlToolbar);
            this.MinimumSize = new System.Drawing.Size(750, 400);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Облік поштових відправлень - PostService";
            this.Load += new System.EventHandler(this.MainForm_Load);

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
