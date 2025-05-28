namespace OOP_lab_14
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDealer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFilterBrand = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lstCars = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtRemoveIndex = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Марка";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(13, 33);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(176, 22);
            this.txtBrand.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Модель";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(195, 33);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(165, 22);
            this.txtModel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Рік випуску";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(366, 33);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 22);
            this.txtYear.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(473, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дилер";
            // 
            // txtDealer
            // 
            this.txtDealer.Location = new System.Drawing.Point(476, 33);
            this.txtDealer.Name = "txtDealer";
            this.txtDealer.Size = new System.Drawing.Size(149, 22);
            this.txtDealer.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(629, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ціна у $ (центи вводити через кому)";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(631, 33);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(143, 22);
            this.txtPrice.TabIndex = 9;
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(16, 84);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(111, 43);
            this.btnAddCar.TabIndex = 10;
            this.btnAddCar.Text = "Додати авто";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.Location = new System.Drawing.Point(133, 84);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(196, 43);
            this.btnDiscount.TabIndex = 11;
            this.btnDiscount.Text = "Знижка 20% на Ford минулого року випуску";
            this.btnDiscount.UseVisualStyleBackColor = true;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(335, 84);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(142, 43);
            this.btnSort.TabIndex = 12;
            this.btnSort.Text = "Сортувати за дилером";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Марка для фільтру:";
            // 
            // txtFilterBrand
            // 
            this.txtFilterBrand.Location = new System.Drawing.Point(153, 163);
            this.txtFilterBrand.Name = "txtFilterBrand";
            this.txtFilterBrand.Size = new System.Drawing.Size(207, 22);
            this.txtFilterBrand.TabIndex = 14;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(366, 162);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(110, 23);
            this.btnFilter.TabIndex = 15;
            this.btnFilter.Text = "Фільтрувати";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(16, 222);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 47);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Зберегти до файлу";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(134, 222);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(114, 47);
            this.btnLoad.TabIndex = 17;
            this.btnLoad.Text = "Завантажити з файлу";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lstCars
            // 
            this.lstCars.FormattingEnabled = true;
            this.lstCars.ItemHeight = 16;
            this.lstCars.Location = new System.Drawing.Point(12, 290);
            this.lstCars.Name = "lstCars";
            this.lstCars.Size = new System.Drawing.Size(864, 308);
            this.lstCars.TabIndex = 18;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(526, 84);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(99, 43);
            this.btnRemove.TabIndex = 19;
            this.btnRemove.Text = "Видалити авто";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtRemoveIndex
            // 
            this.txtRemoveIndex.Location = new System.Drawing.Point(632, 105);
            this.txtRemoveIndex.Name = "txtRemoveIndex";
            this.txtRemoveIndex.Size = new System.Drawing.Size(100, 22);
            this.txtRemoveIndex.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(632, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Введіть індекс для видалення (від 0):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(250, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(226, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Файл повинен мати назву cars.txt!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 603);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRemoveIndex);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lstCars);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.txtFilterBrand);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnDiscount);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDealer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(900, 650);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDealer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFilterBrand;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ListBox lstCars;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtRemoveIndex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

