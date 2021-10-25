using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Step 1: Take Data
            string name = txtname.Text;
            string lastname = txtLname.Text;
            string id = txtID.Text;
            int age = Convert.ToInt32(txtAge.Text);


            Student student;
            // Step 2: Make the Student Object
            if (id == "")
            {

                student = new Student(name, lastname, age);

            }else
            {
                student = new Student(name, lastname, age, id);
            }
            


            // Step 3: ADD it to The label
            string data = student.printIt();
            lblShow.Text += data;

            /* 
             Challenge... 
            ITS NOT OBLIGATORY AND DO IT ONLY IF YOU WANT
            can you make the program in such a way that make these 3 changes in 
            generating the ID:

            A- add a '-' after the first letter of Name and First 
            letter of Lastname for example: MV-

            B- Remove the first 2 digits of year of birth. For example from 
            1991 ---> 91. so MV-91

            C- add a 4 digit random number at the end of generated ID. for
            example The random number is 5232. then The result will be MV-915232

             */



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


    }
}
