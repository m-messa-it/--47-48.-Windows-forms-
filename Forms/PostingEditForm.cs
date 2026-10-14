using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using PostServiceFormsApp.Models;
using PostServiceFormsApp.Services;

namespace PostServiceFormsApp.Forms
{
    public partial class PostingEditForm : Form
    {
        private readonly PostServiceClient _apiClient;
        public Posting Model { get; }

        public PostingEditForm(PostServiceClient apiClient, Posting? existing = null)
        {
            InitializeComponent();
            _apiClient = apiClient ?? new PostServiceClient();
            Model = existing ?? new Posting();

            Text = Model.Id > 0 ? $"Редагування відправлення #{Model.Id}" : "Нове поштове відправлення";
            lblTitle.Text = Model.Id > 0 ? $"Редагування запису #{Model.Id}" : "Нове поштове відправлення";
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
            numValue.Value = Model.Value >= 0 ? Model.Value : 100.0m;
            numPrice.Value = Model.Price >= 0 ? Model.Price : 65.0m;
        }

        // 1. Метод валідації полів
        private bool ValidateInputs()
        {
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(txtFrom.Text) || txtFrom.Text.Trim().Length < 2)
            {
                errorProvider.SetError(txtFrom, "Вкажіть відправника (мінімум 2 символи)");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTo.Text) || txtTo.Text.Trim().Length < 2)
            {
                errorProvider.SetError(txtTo, "Вкажіть одержувача (мінімум 2 символи)");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtContent.Text))
            {
                errorProvider.SetError(txtContent, "Опишіть вміст відправлення");
                return false;
            }

            if (numWeight.Value <= 0)
            {
                errorProvider.SetError(numWeight, "Вага має бути більшою за 0");
                return false;
            }

            if (numLength.Value <= 0 || numWidth.Value <= 0 || numHeight.Value <= 0)
            {
                errorProvider.SetError(numLength, "Розміри мають бути більшими за 0");
                return false;
            }

            return true;
        }

        // 2. Метод побудови об'єкта з інпутів
        private Posting BuildPostingFromInputs()
        {
            return new Posting
            {
                Id = Model.Id,
                From = txtFrom.Text.Trim(),
                To = txtTo.Text.Trim(),
                Content = txtContent.Text.Trim(),
                DeliveryType = cmbDeliveryType.SelectedIndex,
                Weight = numWeight.Value,
                Depth = numLength.Value,
                Width = numWidth.Value,
                Height = numHeight.Value,
                Value = numValue.Value,
                Price = numPrice.Value
            };
        }

        // 3. Окремі методи для додавання та оновлення
        private async Task CreatePostingAsync(Posting posting)
        {
            await _apiClient.CreateAsync(posting);
        }

        private async Task UpdatePostingAsync(Posting posting)
        {
            await _apiClient.UpdateAsync(Model.Id, posting);
        }

        // 4. Кнопка збереження: валідація, формування об'єкта, try-catch, if-else, закриття вікна
        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            var posting = BuildPostingFromInputs();

            try
            {
                btnSave.Enabled = false;

                if (Model.Id == 0)
                {
                    await CreatePostingAsync(posting);
                }
                else
                {
                    await UpdatePostingAsync(posting);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Не вдалося зберегти дані:\n{ex.Message}",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                btnSave.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
