using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace OOP_lab_14
{
    public partial class Form1 : Form
    {
        private CarCollection carCollection = new CarCollection();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBrand.Text) ||
                    string.IsNullOrWhiteSpace(txtModel.Text) ||
                    string.IsNullOrWhiteSpace(txtDealer.Text) ||
                    string.IsNullOrWhiteSpace(txtYear.Text) ||
                    string.IsNullOrWhiteSpace(txtPrice.Text))
                {
                    MessageBox.Show("Будь ласка, заповніть усі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtYear.Text, out int year))
                {
                    MessageBox.Show("Рік повинен бути цілим числом.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (year < 0)
                {
                    MessageBox.Show("Рік не може бути від'ємним.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(txtPrice.Text, out double price))
                {
                    MessageBox.Show("Ціна повинна бути числом.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (price < 0)
                {
                    MessageBox.Show("Ціна не може бути від'ємною.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var car = new Car
                {
                    Brand = txtBrand.Text.Trim(),
                    Model = txtModel.Text.Trim(),
                    Year = year,
                    Dealer = txtDealer.Text.Trim(),
                    Price = price
                };

                carCollection.Cars.Add(car);
                RefreshList();

                MessageBox.Show("Авто успішно додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            carCollection.ApplyDiscountForFordLastYear();
            RefreshList();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            carCollection.SortByDealer();
            RefreshList();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtRemoveIndex.Text, out int index))
                {
                    MessageBox.Show("Введіть коректний індекс.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (index < 0 || index >= carCollection.Cars.Count)
                {
                    MessageBox.Show("Індекс виходить за межі колекції.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                carCollection.Cars.RemoveAt(index);
                RefreshList();
                MessageBox.Show($"Автомобіль за індексом {index} видалено.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка під час видалення: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string brand = txtFilterBrand.Text;
            lstCars.DataSource = carCollection.GetCarsByBrand(brand);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (carCollection.Cars.Count == 0)
                {
                    MessageBox.Show("Немає автомобілів для збереження.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(desktopPath, "cars.txt");

                carCollection.SaveToFile(filePath);
                MessageBox.Show($"Колекцію збережено успішно.\nШлях: {filePath}", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка під час збереження: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(desktopPath, "cars.txt");

                carCollection.LoadFromFile(filePath);
                RefreshList();
                MessageBox.Show($"Колекцію завантажено успішно.\nШлях: {filePath}", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка під час завантаження: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshList()
        {
            lstCars.DataSource = null;
            lstCars.DataSource = carCollection.Cars;
        }

        public class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public string Dealer { get; set; }
            public double Price { get; set; }

            public override string ToString()
            {
                return $"{Brand} {Model} ({Year}) - {Dealer} - ${Price}";
            }
        }

        public class CarCollection
        {
            public List<Car> Cars { get; set; } = new List<Car>();

            public void ApplyDiscountForFordLastYear()
            {
                int lastYear = DateTime.Now.Year - 1;
                foreach (var car in Cars.Where(c => c.Brand.Equals("Ford", StringComparison.OrdinalIgnoreCase) && c.Year == lastYear))
                {
                    car.Price *= 0.8;
                }
            }

            public void SortByDealer()
            {
                Cars = Cars.OrderBy(c => c.Dealer).ToList();
            }

            public List<Car> GetCarsByBrand(string brand)
            {
                return Cars.Where(c => c.Brand.Equals(brand, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            public void SaveToFile(string path)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(path))
                    {
                        foreach (var car in Cars)
                        {
                            writer.WriteLine($"{car.Brand}|{car.Model}|{car.Year}|{car.Dealer}|{car.Price}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Помилка збереження файлу: {ex.Message}");
                }
            }

            public void LoadFromFile(string path)
            {
                try
                {
                    if (!File.Exists(path))
                    {
                        throw new FileNotFoundException("Файл не знайдено");
                    }

                    Cars = new List<Car>();
                    string[] lines = File.ReadAllLines(path);

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('|');

                        if (parts.Length == 5)
                        {
                            Cars.Add(new Car
                            {
                                Brand = parts[0],
                                Model = parts[1],
                                Year = int.Parse(parts[2]),
                                Dealer = parts[3],
                                Price = double.Parse(parts[4])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Помилка завантаження файлу: {ex.Message}");
                }
            }
        }
    }
}