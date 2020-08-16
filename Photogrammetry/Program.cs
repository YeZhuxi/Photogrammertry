using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photogrammetry
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //Calculate cal = new Calculate();

            //cal.GetFrameDistance("InputData/FrameDistance.txt");
            //cal.ReadPhotoData("InputData/PhotoPointData.txt");
            //cal.ReadControlPoint("InputData/ControlPointdata.txt");

            //cal.CorrectPhoto();
            //cal.SpaceResection();
            //cal.SpaceIntersection();
            //cal.RelativeOrientation();
            //cal.AbsoluteOrientation();
            //cal.BeamOrientation();

            //cal.Br.WriteBackwardRendezvousResult("OutputData/BackwardRendezvousResult.txt");
            //cal.WriteForwardRendezvousResult("OutputData/ForwardRendezvousResult.txt");
            //cal.Ao.WriteAbsoluteOrientationResult("OutputData/AbsoluteOrientationResult.txt");
            //cal.Bo.WriteBeamOrientationResult("OutputData/BeamOrientationResult.txt");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainGUI());
        }
    }
}
