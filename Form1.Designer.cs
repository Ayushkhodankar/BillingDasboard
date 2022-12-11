namespace BillingDasboard
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tea = new System.Windows.Forms.Button();
            this.elaichi = new System.Windows.Forms.Button();
            this.maggie = new System.Windows.Forms.Button();
            this.coffee = new System.Windows.Forms.Button();
            this.listItem = new System.Windows.Forms.ListView();
            this.Iname = new System.Windows.Forms.ColumnHeader();
            this.quantity = new System.Windows.Forms.ColumnHeader();
            this.amount = new System.Windows.Forms.ColumnHeader();
            this.total = new System.Windows.Forms.Label();
            this.totalAmount1 = new System.Windows.Forms.TextBox();
            this.print = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Chocolate;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(280, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cafe Point";
            // 
            // tea
            // 
            this.tea.Location = new System.Drawing.Point(51, 86);
            this.tea.Name = "tea";
            this.tea.Size = new System.Drawing.Size(113, 53);
            this.tea.TabIndex = 1;
            this.tea.Text = "Tea";
            this.tea.UseVisualStyleBackColor = true;
            this.tea.Click += new System.EventHandler(this.button1_Click);
            // 
            // elaichi
            // 
            this.elaichi.Location = new System.Drawing.Point(205, 86);
            this.elaichi.Name = "elaichi";
            this.elaichi.Size = new System.Drawing.Size(113, 53);
            this.elaichi.TabIndex = 2;
            this.elaichi.Text = "Elaichi Tea";
            this.elaichi.UseVisualStyleBackColor = true;
            this.elaichi.Click += new System.EventHandler(this.elaichi_Click);
            // 
            // maggie
            // 
            this.maggie.Location = new System.Drawing.Point(360, 86);
            this.maggie.Name = "maggie";
            this.maggie.Size = new System.Drawing.Size(129, 53);
            this.maggie.TabIndex = 3;
            this.maggie.Text = "Maggie";
            this.maggie.UseVisualStyleBackColor = true;
            this.maggie.Click += new System.EventHandler(this.maggie_Click);
            // 
            // coffee
            // 
            this.coffee.Location = new System.Drawing.Point(525, 86);
            this.coffee.Name = "coffee";
            this.coffee.Size = new System.Drawing.Size(129, 53);
            this.coffee.TabIndex = 4;
            this.coffee.Text = "Coffee";
            this.coffee.UseVisualStyleBackColor = true;
            this.coffee.Click += new System.EventHandler(this.coffee_Click);
            // 
            // listItem
            // 
            this.listItem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Iname,
            this.quantity,
            this.amount});
            this.listItem.Location = new System.Drawing.Point(64, 156);
            this.listItem.Name = "listItem";
            this.listItem.Size = new System.Drawing.Size(579, 155);
            this.listItem.TabIndex = 5;
            this.listItem.UseCompatibleStateImageBehavior = false;
            this.listItem.View = System.Windows.Forms.View.Details;
            this.listItem.SelectedIndexChanged += new System.EventHandler(this.listItem_SelectedIndexChanged);
            // 
            // Iname
            // 
            this.Iname.Text = "Item Name";
            this.Iname.Width = 275;
            // 
            // quantity
            // 
            this.quantity.Text = "Quantity";
            this.quantity.Width = 150;
            // 
            // amount
            // 
            this.amount.Text = "Amount";
            this.amount.Width = 150;
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.total.Location = new System.Drawing.Point(422, 326);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(54, 25);
            this.total.TabIndex = 6;
            this.total.Text = "Total";
            // 
            // totalAmount1
            // 
            this.totalAmount1.Location = new System.Drawing.Point(495, 324);
            this.totalAmount1.Name = "totalAmount1";
            this.totalAmount1.Size = new System.Drawing.Size(148, 27);
            this.totalAmount1.TabIndex = 7;
            this.totalAmount1.TextChanged += new System.EventHandler(this.totalAmount_TextChanged);
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(288, 365);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(176, 51);
            this.print.TabIndex = 8;
            this.print.Text = "Print Bill";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 435);
            this.Controls.Add(this.print);
            this.Controls.Add(this.totalAmount1);
            this.Controls.Add(this.total);
            this.Controls.Add(this.listItem);
            this.Controls.Add(this.coffee);
            this.Controls.Add(this.maggie);
            this.Controls.Add(this.elaichi);
            this.Controls.Add(this.tea);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button tea;
        private Button elaichi;
        private Button maggie;
        private Button coffee;
        private ListView listItem;
        private ColumnHeader Iname;
        private ColumnHeader quantity;
        private ColumnHeader amount;
        private Label total;
        private TextBox totalAmount1;
        private Button print;
    }
}