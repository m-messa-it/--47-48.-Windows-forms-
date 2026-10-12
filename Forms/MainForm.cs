using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using PostServiceFormsApp.Models;
using PostServiceFormsApp.Services;

namespace PostServiceFormsApp.Forms
{
    public partial class MainForm : Form
    {
        private readonly PostServiceClient _apiClient = new();
        private List<Posting> _currentPostings = new();

        public MainForm()
        {
            InitializeComponent();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            txtServerUrl.Text = _apiClient.BaseUrl;
            await LoadPostingsAsync();
        }

        private async Task LoadPostingsAsync()
        {
            try
            {
                lblStatus.Text = "⏳ Завантаження списку відправлень...";
                lblStatus.ForeColor = Color.Black;
                btnRefresh.Enabled = false;

                _apiClient.BaseUrl = txtServerUrl.Text.Trim();
                _currentPostings = await _apiClient.GetAllAsync();

                dgvPostings.DataSource = null;
                dgvPostings.DataSource = _currentPostings;

                lblCount.Text = $"Всього записів: {_currentPostings.Count}";

                if (_apiClient.IsUsingMock)
                {
                    lblStatus.Text = "⚠️ Сервер недоступний (працює локальний демонстраційний режим)";
                    lblStatus.ForeColor = Color.DarkOrange;
                }
                else
                {
                    lblStatus.Text = "✅ Дані успішно завантажено із сервера PostService";
                    lblStatus.ForeColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = $"❌ Помилка: {ex.Message}";
                lblStatus.ForeColor = Color.Red;
                MessageBox.Show(
                    $"Не вдалося отримати дані з сервера:\n{ex.Message}",
                    "Помилка зв'язку",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                btnRefresh.Enabled = true;
            }
        }

        private Posting? GetSelectedPosting()
        {
            if (dgvPostings.SelectedRows.Count > 0)
            {
                return dgvPostings.SelectedRows[0].DataBoundItem as Posting;
            }
            return null;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            using var editForm = new PostingEditForm();
            if (editForm.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    lblStatus.Text = "Збереження нового відправлення...";
                    await _apiClient.CreateAsync(editForm.Model);
                    MessageBox.Show(
                        "Відправлення успішно створено!",
                        "Успіх",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    await LoadPostingsAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Не вдалося створити відправлення:\n{ex.Message}",
                        "Помилка операції",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            var selected = GetSelectedPosting();
            if (selected == null)
            {
                MessageBox.Show(
                    "Будь ласка, виберіть відправлення зі списку для редагування!",
                    "Увага",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            // Клонуємо об'єкт для редагування
            var copy = new Posting
            {
                Id = selected.Id,
                From = selected.From,
                To = selected.To,
                Content = selected.Content,
                DeliveryType = selected.DeliveryType,
                Weight = selected.Weight,
                Width = selected.Width,
                Height = selected.Height,
                Depth = selected.Depth,
                Value = selected.Value,
                Price = selected.Price
            };

            using var editForm = new PostingEditForm(copy);
            if (editForm.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    lblStatus.Text = $"Оновлення відправлення #{selected.Id}...";
                    await _apiClient.UpdateAsync(selected.Id, editForm.Model);
                    MessageBox.Show(
                        "Зміни успішно збережено!",
                        "Успіх",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    await LoadPostingsAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Не вдалося зберегти зміни:\n{ex.Message}",
                        "Помилка операції",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var selected = GetSelectedPosting();
            if (selected == null)
            {
                MessageBox.Show(
                    "Будь ласка, виберіть відправлення для видалення!",
                    "Увага",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            var confirmResult = MessageBox.Show(
                $"Ви дійсно бажаєте видалити відправлення #{selected.Id} ({selected.Content}) від {selected.From} до {selected.To}?",
                "Підтвердження видалення",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    lblStatus.Text = $"Видалення відправлення #{selected.Id}...";
                    await _apiClient.DeleteAsync(selected.Id);
                    MessageBox.Show(
                        "Відправлення успішно видалено!",
                        "Успіх",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    await LoadPostingsAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Не вдалося видалити відправлення:\n{ex.Message}",
                        "Помилка операції",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadPostingsAsync();
        }

        private void dgvPostings_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnEdit_Click(sender, e);
            }
        }
    }
}
