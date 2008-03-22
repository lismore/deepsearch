using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DeepGoogle
{
    public partial class frmOne : Form
    {
        public frmOne()
        {
            InitializeComponent();
        }

        private void frmOne_Load(object sender, EventArgs e)
        {
            txtSearch.Focus();
            txtSearch.TabIndex = 0;


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            String query = txtSearch.Text;


            

            if (tabOne.Focused == true)
            {
                if (cbMp3.Checked == true)
                {
                    //call dll method
                }

                if (cbOgg.Checked == true)
                {

                    //call dll method
                }

                if (cbWma.Checked == true)
                {

                    //call dll method
                }
                if (cbFlac.Checked == true)
                {

                    //call dll method
                }
                if (cbWav.Checked == true)
                {

                    //call dll method
                }
                if (cbAu.Checked == true)
                {

                    //call dll method
                }
                if (cbAiff.Checked == true)
                {

                    //call dll method
                }
                if (cbRa.Checked == true)
                {

                    //call dll method
                }
                if (cbRam.Checked == true)
                {

                    //call dll method
                }
                if (cbVox.Checked == true)
                {

                    //call dll method
                }
                if (cbDct.Checked == true)
                {

                    //call dll method
                }
                if (cbGsm.Checked == true)
                {

                    //call dll method
                }


            }
            if (tabTwo.Focused == true)
            {

            }
            if (tabThree.Focused == true)
            {

            }
            if (tabFour.Focused == true)
            {

            }
            if (tabFive.Focused == true)
            {

            }
            if (tabSix.Focused == true)
            {

            }
            if (tabSeven.Focused == true)
            {

            }
            if (tabEight.Focused == true)
            {

            }
            if (tabNine.Focused == true)
            {

            }
            if (tabTen.Focused == true)
            {

            }
            
        }



        
    }
}