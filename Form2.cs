using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Consumer.App
{
    public partial class Form2 : MaterialForm
    {
        private byte[] _photoBytes = null;

        public Form2()
        {
            InitializeComponent();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPin.Text) ||
                string.IsNullOrEmpty(txtNewName.Text) ||
                string.IsNullOrEmpty(txtNewBirth.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            var json = "{\"pin\":\"" + txtNewPin.Text.Trim() + "\",\"name\":\"" + txtNewName.Text.Trim() + "\",\"gender\":0,\"birthDate\":\"" + txtNewBirth.Text.Trim() + "T00:00:00\"}";
            var client = new HttpClient();
            try
            {
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("http://localhost:5197/person", content);
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Человек добавлен!");
                else
                    MessageBox.Show("Ошибка при добавлении.");
            }
            catch
            {
                MessageBox.Show("Сервер не запущен!");
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPin.Text))
            {
                MessageBox.Show("Введите PIN для удаления!");
                return;
            }

            var client = new HttpClient();
            try
            {
                var response = await client.DeleteAsync("http://localhost:5197/person/" + txtNewPin.Text.Trim());
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("Человек удалён!");
                else
                    MessageBox.Show("Человек не найден.");
            }
            catch
            {
                MessageBox.Show("Сервер не запущен!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtNewPin.Text = "";
            txtNewName.Text = "";
            txtNewBirth.Text = "";
            _photoBytes = null;
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Изображения|*.jpg;*.jpeg;*.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _photoBytes = System.IO.File.ReadAllBytes(dialog.FileName);
                picPhoto.Image = System.Drawing.Image.FromFile(dialog.FileName);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is Form1)
                {
                    f.Show();
                    break;
                }
            }
            this.Close();
        }

    }
}