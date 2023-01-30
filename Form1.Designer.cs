
namespace EntityFrameworkSample
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
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.studentBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.findBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.lecturesBtn = new System.Windows.Forms.Button();
            this.gradesBtn = new System.Windows.Forms.Button();
            this.procedureBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.updateGradeBtn = new System.Windows.Forms.Button();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.textBoxAVG = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxGrade2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxGrade1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewList
            // 
            this.dataGridViewList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewList.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewList.MultiSelect = false;
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.RowHeadersWidth = 51;
            this.dataGridViewList.RowTemplate.Height = 24;
            this.dataGridViewList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewList.Size = new System.Drawing.Size(1099, 352);
            this.dataGridViewList.TabIndex = 0;
            this.dataGridViewList.Click += new System.EventHandler(this.dataGridViewList_Click);
            // 
            // studentBtn
            // 
            this.studentBtn.Location = new System.Drawing.Point(152, 360);
            this.studentBtn.Name = "studentBtn";
            this.studentBtn.Size = new System.Drawing.Size(119, 38);
            this.studentBtn.TabIndex = 1;
            this.studentBtn.Text = "Students";
            this.studentBtn.UseVisualStyleBackColor = true;
            this.studentBtn.Click += new System.EventHandler(this.studentBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(12, 360);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(109, 38);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(12, 411);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(109, 38);
            this.updateBtn.TabIndex = 3;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // findBtn
            // 
            this.findBtn.Location = new System.Drawing.Point(12, 463);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(109, 38);
            this.findBtn.TabIndex = 4;
            this.findBtn.Text = "Find";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(12, 511);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(109, 43);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // lecturesBtn
            // 
            this.lecturesBtn.Location = new System.Drawing.Point(153, 411);
            this.lecturesBtn.Name = "lecturesBtn";
            this.lecturesBtn.Size = new System.Drawing.Size(118, 38);
            this.lecturesBtn.TabIndex = 6;
            this.lecturesBtn.Text = "Lectures";
            this.lecturesBtn.UseVisualStyleBackColor = true;
            this.lecturesBtn.Click += new System.EventHandler(this.lecturesBtn_Click);
            // 
            // gradesBtn
            // 
            this.gradesBtn.Location = new System.Drawing.Point(153, 463);
            this.gradesBtn.Name = "gradesBtn";
            this.gradesBtn.Size = new System.Drawing.Size(118, 38);
            this.gradesBtn.TabIndex = 7;
            this.gradesBtn.Text = "Grades";
            this.gradesBtn.UseVisualStyleBackColor = true;
            this.gradesBtn.Click += new System.EventHandler(this.gradesBtn_Click);
            // 
            // procedureBtn
            // 
            this.procedureBtn.Location = new System.Drawing.Point(152, 511);
            this.procedureBtn.Name = "procedureBtn";
            this.procedureBtn.Size = new System.Drawing.Size(119, 43);
            this.procedureBtn.TabIndex = 8;
            this.procedureBtn.Text = "Procedure";
            this.procedureBtn.UseVisualStyleBackColor = true;
            this.procedureBtn.Click += new System.EventHandler(this.procedureBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxID);
            this.groupBox1.Controls.Add(this.textBoxSurname);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.idLabel);
            this.groupBox1.Controls.Add(this.surnameLabel);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Location = new System.Drawing.Point(292, 358);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 214);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(145, 114);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 29);
            this.textBoxID.TabIndex = 5;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(145, 81);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 29);
            this.textBoxSurname.TabIndex = 4;
            this.textBoxSurname.TextChanged += new System.EventHandler(this.textBoxSurname_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(145, 46);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 29);
            this.textBoxName.TabIndex = 3;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(97, 117);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(36, 22);
            this.idLabel.TabIndex = 2;
            this.idLabel.Text = "ID:";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(32, 84);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(101, 22);
            this.surnameLabel.TabIndex = 1;
            this.surnameLabel.Text = "Surname:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(64, 49);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(69, 22);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clearBtn);
            this.groupBox2.Controls.Add(this.updateGradeBtn);
            this.groupBox2.Controls.Add(this.calculateBtn);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxState);
            this.groupBox2.Controls.Add(this.textBoxAVG);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxGrade2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxGrade1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(570, 360);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 214);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(273, 153);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(142, 38);
            this.clearBtn.TabIndex = 16;
            this.clearBtn.Text = "CLEAR";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // updateGradeBtn
            // 
            this.updateGradeBtn.Location = new System.Drawing.Point(273, 99);
            this.updateGradeBtn.Name = "updateGradeBtn";
            this.updateGradeBtn.Size = new System.Drawing.Size(142, 38);
            this.updateGradeBtn.TabIndex = 15;
            this.updateGradeBtn.Text = "UPDATE";
            this.updateGradeBtn.UseVisualStyleBackColor = true;
            this.updateGradeBtn.Click += new System.EventHandler(this.updateGradeBtn_Click);
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(273, 40);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(142, 38);
            this.calculateBtn.TabIndex = 13;
            this.calculateBtn.Text = "CALCULATE";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "State:";
            // 
            // textBoxState
            // 
            this.textBoxState.Location = new System.Drawing.Point(137, 159);
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(100, 29);
            this.textBoxState.TabIndex = 14;
            // 
            // textBoxAVG
            // 
            this.textBoxAVG.Location = new System.Drawing.Point(137, 120);
            this.textBoxAVG.Name = "textBoxAVG";
            this.textBoxAVG.Size = new System.Drawing.Size(100, 29);
            this.textBoxAVG.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Grade2:";
            // 
            // textBoxGrade2
            // 
            this.textBoxGrade2.Location = new System.Drawing.Point(137, 83);
            this.textBoxGrade2.Name = "textBoxGrade2";
            this.textBoxGrade2.Size = new System.Drawing.Size(100, 29);
            this.textBoxGrade2.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Grade1:";
            // 
            // textBoxGrade1
            // 
            this.textBoxGrade1.Location = new System.Drawing.Point(137, 44);
            this.textBoxGrade1.Name = "textBoxGrade1";
            this.textBoxGrade1.Size = new System.Drawing.Size(100, 29);
            this.textBoxGrade1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "AVG:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 591);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.procedureBtn);
            this.Controls.Add(this.gradesBtn);
            this.Controls.Add(this.lecturesBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.studentBtn);
            this.Controls.Add(this.dataGridViewList);
            this.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.Button studentBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button lecturesBtn;
        private System.Windows.Forms.Button gradesBtn;
        private System.Windows.Forms.Button procedureBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxState;
        private System.Windows.Forms.TextBox textBoxAVG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxGrade2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxGrade1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button updateGradeBtn;
        private System.Windows.Forms.Button calculateBtn;
    }
}

