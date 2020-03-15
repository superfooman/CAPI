using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPI
{
    public partial class MovingAvgUI : Form
    {
        private MovingAvgConfig movingAvgClass = new MovingAvgConfig();
        public MovingAvgUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                inputArraypropertyGrid.SelectedObject = movingAvgClass;
                movingAvgClass.OutputResult = MovingAvgWrapper.CalculateMovingAvgArray(movingAvgClass.InputArray, movingAvgClass.WindowArray);

                for (int i = 0; i < movingAvgClass.OutputResult.Length; i++)
                {
                    outputTextBox.AppendText(movingAvgClass.OutputResult[i].ToString() + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error: " + ex.Message), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void MovingAvgUI_Load(object sender, EventArgs e)
        {
            inputArraypropertyGrid.SelectedObject = movingAvgClass;
        }
    }
}
