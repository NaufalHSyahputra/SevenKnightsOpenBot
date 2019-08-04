using Emgu.CV;
using Emgu.CV.Structure;
using System.Drawing;

namespace SevenKnightsAI.Classes.Imaging
{
    internal class ImageSearch
    {
        public static bool SearchBool(string imgTargetPath, string imgSourcePath, double accuracy = 0.9)
        {
            string imgSource = imgSourcePath;
            string imgSearch = imgTargetPath;// Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\a.png";//inputImageTargetPath.Text;

            Image<Bgr, byte> source = new Image<Bgr, byte>(imgSource); // Image B
            Image<Bgr, byte> template = new Image<Bgr, byte>(imgSearch); // Image A
            Image<Bgr, byte> imageToShow = source.Copy();

            using (Image<Gray, float> result = source.MatchTemplate(template, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed))

            {
                result.MinMax(out double[] minValues, out double[] maxValues, out Point[] minLocations, out Point[] maxLocations);
                // accuracy: You can try different values of the threshold. I guess somewhere between 0.75 and 0.95 would be good.
                if (maxValues[0] > accuracy)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
