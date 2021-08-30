
namespace introToForms
{
    partial class myMenu
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
            this.dgvAnimal = new System.Windows.Forms.DataGridView();
            this.btnNavToStart = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.rbtnDog = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewCats = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnViewDogs = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rbtnCat = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNavToEnd = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPLace = new System.Windows.Forms.TextBox();
            this.txtPlaceHolder = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAnimal
            // 
            this.dgvAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimal.Location = new System.Drawing.Point(12, 32);
            this.dgvAnimal.Name = "dgvAnimal";
            this.dgvAnimal.Size = new System.Drawing.Size(602, 110);
            this.dgvAnimal.TabIndex = 0;
            this.dgvAnimal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAnimal_CellContentClick);
            this.dgvAnimal.SelectionChanged += new System.EventHandler(this.dgvAnimal_SelectionChanged);
            // 
            // btnNavToStart
            // 
            this.btnNavToStart.Location = new System.Drawing.Point(6, 19);
            this.btnNavToStart.Name = "btnNavToStart";
            this.btnNavToStart.Size = new System.Drawing.Size(75, 23);
            this.btnNavToStart.TabIndex = 1;
            this.btnNavToStart.Text = "<<";
            this.btnNavToStart.UseVisualStyleBackColor = true;
            this.btnNavToStart.Click += new System.EventHandler(this.btnNavToStart_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(74, 261);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 2;
            // 
            // rbtnDog
            // 
            this.rbtnDog.AutoSize = true;
            this.rbtnDog.Checked = true;
            this.rbtnDog.Location = new System.Drawing.Point(33, 335);
            this.rbtnDog.Name = "rbtnDog";
            this.rbtnDog.Size = new System.Drawing.Size(45, 17);
            this.rbtnDog.TabIndex = 3;
            this.rbtnDog.TabStop = true;
            this.rbtnDog.Text = "Dog";
            this.rbtnDog.UseVisualStyleBackColor = true;
            this.rbtnDog.Click += new System.EventHandler(this.rbtnDog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "My Zoo";
            // 
            // btnViewCats
            // 
            this.btnViewCats.Location = new System.Drawing.Point(629, 110);
            this.btnViewCats.Name = "btnViewCats";
            this.btnViewCats.Size = new System.Drawing.Size(75, 23);
            this.btnViewCats.TabIndex = 5;
            this.btnViewCats.Text = "View Cats";
            this.btnViewCats.UseVisualStyleBackColor = true;
            this.btnViewCats.Click += new System.EventHandler(this.btnViewCats_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(30, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(132, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "search by name";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(629, 52);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(75, 23);
            this.btnViewAll.TabIndex = 7;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // btnViewDogs
            // 
            this.btnViewDogs.Location = new System.Drawing.Point(629, 81);
            this.btnViewDogs.Name = "btnViewDogs";
            this.btnViewDogs.Size = new System.Drawing.Size(75, 23);
            this.btnViewDogs.TabIndex = 8;
            this.btnViewDogs.Text = "View Dogs";
            this.btnViewDogs.UseVisualStyleBackColor = true;
            this.btnViewDogs.Click += new System.EventHandler(this.btnViewDogs_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(9, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(180, 20);
            this.txtSearch.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(74, 217);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 10;
            // 
            // rbtnCat
            // 
            this.rbtnCat.AutoSize = true;
            this.rbtnCat.Location = new System.Drawing.Point(33, 358);
            this.rbtnCat.Name = "rbtnCat";
            this.rbtnCat.Size = new System.Drawing.Size(41, 17);
            this.rbtnCat.TabIndex = 12;
            this.rbtnCat.Text = "Cat";
            this.rbtnCat.UseVisualStyleBackColor = true;
            this.rbtnCat.CheckedChanged += new System.EventHandler(this.rbtnCat_CheckedChanged);
            this.rbtnCat.Click += new System.EventHandler(this.rbtnCat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(626, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "view Options";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Location = new System.Drawing.Point(528, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 98);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "find by name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNavToEnd);
            this.groupBox2.Controls.Add(this.btnPrevious);
            this.groupBox2.Controls.Add(this.btnNext);
            this.groupBox2.Controls.Add(this.btnNavToStart);
            this.groupBox2.Location = new System.Drawing.Point(12, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 48);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Navigation";
            // 
            // btnNavToEnd
            // 
            this.btnNavToEnd.Location = new System.Drawing.Point(275, 19);
            this.btnNavToEnd.Name = "btnNavToEnd";
            this.btnNavToEnd.Size = new System.Drawing.Size(75, 23);
            this.btnNavToEnd.TabIndex = 5;
            this.btnNavToEnd.Text = ">>";
            this.btnNavToEnd.UseVisualStyleBackColor = true;
            this.btnNavToEnd.Click += new System.EventHandler(this.btnNavToEnd_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(87, 19);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(194, 19);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(265, 316);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtFee
            // 
            this.txtFee.Location = new System.Drawing.Point(74, 292);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(100, 20);
            this.txtFee.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Adoption fee";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Age:";
            // 
            // txtPLace
            // 
            this.txtPLace.Location = new System.Drawing.Point(109, 386);
            this.txtPLace.Name = "txtPLace";
            this.txtPLace.Size = new System.Drawing.Size(100, 20);
            this.txtPLace.TabIndex = 20;
            // 
            // txtPlaceHolder
            // 
            this.txtPlaceHolder.AutoSize = true;
            this.txtPlaceHolder.Location = new System.Drawing.Point(10, 389);
            this.txtPlaceHolder.Name = "txtPlaceHolder";
            this.txtPlaceHolder.Size = new System.Drawing.Size(35, 13);
            this.txtPlaceHolder.TabIndex = 21;
            this.txtPlaceHolder.Text = "Breed";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(378, 316);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(573, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Finish";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // myMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtPlaceHolder);
            this.Controls.Add(this.txtPLace);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFee);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbtnCat);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnViewDogs);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.btnViewCats);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtnDog);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.dgvAnimal);
            this.Name = "myMenu";
            this.Text = "My Zoo";
            this.Load += new System.EventHandler(this.myMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAnimal;
        private System.Windows.Forms.Button btnNavToStart;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.RadioButton rbtnDog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewCats;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnViewDogs;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton rbtnCat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNavToEnd;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPLace;
        private System.Windows.Forms.Label txtPlaceHolder;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button1;
    }
}

