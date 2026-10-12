namespace PostServiceFormsApp.Forms
{
    partial class PostingEditForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label lblDeliveryType;
        private System.Windows.Forms.ComboBox cmbDeliveryType;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.NumericUpDown numWeight;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.NumericUpDown numLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.NumericUpDown numValue;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider;

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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.lblContent = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.lblDeliveryType = new System.Windows.Forms.Label();
            this.cmbDeliveryType = new System.Windows.Forms.ComboBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.numWeight = new System.Windows.Forms.NumericUpDown();
            this.lblLength = new System.Windows.Forms.Label();
            this.numLength = new System.Windows.Forms.NumericUpDown();
            this.lblWidth = new System.Windows.Forms.Label();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.lblHeight = new System.Windows.Forms.Label();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.lblValue = new System.Windows.Forms.Label();
            this.numValue = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);

            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 90, 158);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(260, 21);
            this.lblTitle.Text = "Нове поштове відправлення";

            // lblFrom
            this.lblFrom.Location = new System.Drawing.Point(20, 60);
            this.lblFrom.Size = new System.Drawing.Size(140, 20);
            this.lblFrom.Text = "Відправник (місто/ПІБ):";
            this.txtFrom.Location = new System.Drawing.Point(170, 58);
            this.txtFrom.Size = new System.Drawing.Size(260, 23);

            // lblTo
            this.lblTo.Location = new System.Drawing.Point(20, 95);
            this.lblTo.Size = new System.Drawing.Size(140, 20);
            this.lblTo.Text = "Одержувач (місто/ПІБ):";
            this.txtTo.Location = new System.Drawing.Point(170, 93);
            this.txtTo.Size = new System.Drawing.Size(260, 23);

            // lblContent
            this.lblContent.Location = new System.Drawing.Point(20, 130);
            this.lblContent.Size = new System.Drawing.Size(140, 20);
            this.lblContent.Text = "Опис вмісту:";
            this.txtContent.Location = new System.Drawing.Point(170, 128);
            this.txtContent.Size = new System.Drawing.Size(260, 23);

            // lblDeliveryType
            this.lblDeliveryType.Location = new System.Drawing.Point(20, 165);
            this.lblDeliveryType.Size = new System.Drawing.Size(140, 20);
            this.lblDeliveryType.Text = "Тип доставки:";
            this.cmbDeliveryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeliveryType.Location = new System.Drawing.Point(170, 163);
            this.cmbDeliveryType.Size = new System.Drawing.Size(260, 23);

            // lblWeight
            this.lblWeight.Location = new System.Drawing.Point(20, 200);
            this.lblWeight.Size = new System.Drawing.Size(140, 20);
            this.lblWeight.Text = "Вага (кг):";
            this.numWeight.DecimalPlaces = 2;
            this.numWeight.Increment = 0.5m;
            this.numWeight.Maximum = 1000m;
            this.numWeight.Location = new System.Drawing.Point(170, 198);
            this.numWeight.Size = new System.Drawing.Size(120, 23);

            // lblLength (Depth)
            this.lblLength.Location = new System.Drawing.Point(20, 235);
            this.lblLength.Size = new System.Drawing.Size(140, 20);
            this.lblLength.Text = "Довжина (см):";
            this.numLength.DecimalPlaces = 1;
            this.numLength.Maximum = 500m;
            this.numLength.Location = new System.Drawing.Point(170, 233);
            this.numLength.Size = new System.Drawing.Size(120, 23);

            // lblWidth
            this.lblWidth.Location = new System.Drawing.Point(20, 270);
            this.lblWidth.Size = new System.Drawing.Size(140, 20);
            this.lblWidth.Text = "Ширина (см):";
            this.numWidth.DecimalPlaces = 1;
            this.numWidth.Maximum = 500m;
            this.numWidth.Location = new System.Drawing.Point(170, 268);
            this.numWidth.Size = new System.Drawing.Size(120, 23);

            // lblHeight
            this.lblHeight.Location = new System.Drawing.Point(20, 305);
            this.lblHeight.Size = new System.Drawing.Size(140, 20);
            this.lblHeight.Text = "Висота (см):";
            this.numHeight.DecimalPlaces = 1;
            this.numHeight.Maximum = 500m;
            this.numHeight.Location = new System.Drawing.Point(170, 303);
            this.numHeight.Size = new System.Drawing.Size(120, 23);

            // lblValue
            this.lblValue.Location = new System.Drawing.Point(20, 340);
            this.lblValue.Size = new System.Drawing.Size(140, 20);
            this.lblValue.Text = "Оголошена вартість (грн):";
            this.numValue.DecimalPlaces = 2;
            this.numValue.Maximum = 1000000m;
            this.numValue.Location = new System.Drawing.Point(170, 338);
            this.numValue.Size = new System.Drawing.Size(120, 23);

            // lblPrice
            this.lblPrice.Location = new System.Drawing.Point(20, 375);
            this.lblPrice.Size = new System.Drawing.Size(140, 20);
            this.lblPrice.Text = "Ціна доставки (грн):";
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Maximum = 100000m;
            this.numPrice.Location = new System.Drawing.Point(170, 373);
            this.numPrice.Size = new System.Drawing.Size(120, 23);

            // btnSave
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(225, 420);
            this.btnSave.Size = new System.Drawing.Size(100, 32);
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(335, 420);
            this.btnCancel.Size = new System.Drawing.Size(95, 32);
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // errorProvider
            this.errorProvider.ContainerControl = this;

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 475);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.lblDeliveryType);
            this.Controls.Add(this.cmbDeliveryType);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.numWeight);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.numLength);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.numWidth);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.numHeight);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.numValue);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Load += new System.EventHandler(this.PostingEditForm_Load);

            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
