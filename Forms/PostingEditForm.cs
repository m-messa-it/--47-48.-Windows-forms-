using System;
using System.ComponentModel;
using System.Windows.Forms;
using PostServiceFormsApp.Models;

namespace PostServiceFormsApp.Forms
{
    public partial class PostingEditForm : Form
    {
        public Posting Model { get; private set; }
        public bool IsEditMode { get; }

        public PostingEditForm(Posting? existing = null)
        {
            InitializeComponent();
            IsEditMode = existing != null;
            Model = existing ?? new Posting
            {
                DeliveryType = 0,
                Weight = 1.0m,
                Width = 20.0m,
                Height = 10.0m,
                Depth = 15.0m,
                Value = 100.0m,
                Price = 80.0m
            };

            Text = IsEditMode ? $"Редагування відправлення #{Model.Id}" : "Створення нового відправлення";
            lblTitle.Text = IsEditMode ? $"Редагування запису #{Model.Id}" : "Нове поштове відправлення";
        }

        private void PostingEditForm_Load(object sender, EventArgs e)
        {
            cmbDeliveryType.Items.Clear();
            cmbDeliveryType.Items.Add("Стандартна (у відділення)");
            cmbDeliveryType.Items.Add("Кур'єрська доставка");
            cmbDeliveryType.SelectedIndex = Model.DeliveryType == 1 ? 1 : 0;

            txtFrom.Text = Model.From;
            txtTo.Text = Model.To;
            txtContent.Text = Model.Content;
            numWeight.Value = Model.Weight > 0 ? Model.Weight : 1.0m;
            numLength.Value = Model.Depth > 0 ? Model.Depth : 15.0m;
            numWidth.Value = Model.Width > 0 ? Model.Width : 20.0m;
            numHeight.Value = Model.Height > 0 ? Model.Height : 10.0m;
            numValue.Value = Model.Value >= 0 ? Model.Value : 0m;
            numPrice.Value = Model.Price >= 0 ? Model.Price : 50m;
        }

        private bool ValidateForm()
        {
            bool isValid = true;
            errorProvider.Clear();

            // Відправник
            if (string.IsNullOrWhiteSpace(txtFrom.Text))
            {
                errorProvider.SetError(txtFrom, "Вкажіть відправника (поле обов'язкове)");
                isValid = false;
            }
            else if (txtFrom.Text.Trim().Length < 2)
            {
                errorProvider.SetError(txtFrom, "Назва відправника занадто коротка (мінімум 2 символи)");
                isValid = false;
            }

            // Одержувач
            if (string.IsNullOrWhiteSpace(txtTo.Text))
            {
                errorProvider.SetError(txtTo, "Вкажіть одержувача (поле обов'язкове)");
                isValid = false;
            }
            else if (txtTo.Text.Trim().Length < 2)
            {
                errorProvider.SetError(txtTo, "Назва одержувача занадто коротка (мінімум 2 символи)");
                isValid = false;
            }

            // Вміст
            if (string.IsNullOrWhiteSpace(txtContent.Text))
            {
                errorProvider.SetError(txtContent, "Опишіть вміст відправлення");
                isValid = false;
            }

            // Вага
            if (numWeight.Value <= 0)
            {
                errorProvider.SetError(numWeight, "Вага посилки має бути більшою за 0");
                isValid = false;
            }

            // Габарити
            if (numLength.Value <= 0 || numWidth.Value <= 0 || numHeight.Value <= 0)
            {
                errorProvider.SetError(numLength, "Розміри мають бути більшими за 0");
                isValid = false;
            }

            return isValid;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                MessageBox.Show(
                    "Будь ласка, виправте виділені помилки перед збереженням!",
                    "Помилка перевірки даних",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            Model.From = txtFrom.Text.Trim();
            Model.To = txtTo.Text.Trim();
            Model.Content = txtContent.Text.Trim();
            Model.DeliveryType = cmbDeliveryType.SelectedIndex;
            Model.Weight = numWeight.Value;
            Model.Depth = numLength.Value;
            Model.Width = numWidth.Value;
            Model.Height = numHeight.Value;
            Model.Value = numValue.Value;
            Model.Price = numPrice.Value;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
