using System;
using System.Drawing;
using System.Drawing.Imaging;
using c = System.Console;

namespace BarcodeGenerator {
    class Program {
        private static int OneLineWidth = 2, ThreeLineWidth = 8,
            x = 500, y = 150, xn = 10;
        private static Pen p1 = new Pen(Brushes.Black, 3.0F);
        private static Pen p3 = new Pen(Brushes.Black, 9.0F);
        private static Graphics g;

        static void Main(string[] args) {
            c.WriteLine("Performing Barcode Calculations...");

            var exitMessage = "";

            if (GenerateBarcodeImage(10010010010010)) {
                exitMessage = "Successfully created the Barcode image.";
            } else {
                exitMessage = "Barcode image creation unsuccessful.";
            }

            c.Write("{0}  Press any key to exit.", exitMessage);
            //c.ReadLine();
        }

        private static bool GenerateBarcodeImage(long numberToConvert) {

            char[] conversionArr = numberToConvert.ToString().ToCharArray();

            Bitmap bcImg = new Bitmap(x, y);

            using (g = Graphics.FromImage(bcImg))
            using (SolidBrush br = new SolidBrush(Color.White)) {
                g.FillRectangle(br, new Rectangle(0, 0, x, y));

                // Add a Space Befor the Start Sentinal
                xn += OneLineWidth;

                // Draw the Start Sentinal
                CodabarCharacter.a startSentinal = new CodabarCharacter.a();
                DrawCharacterBars(startSentinal.Bars, startSentinal.Spaces);

                //Add a Space after Each Character
                xn += OneLineWidth;

                foreach (char c in conversionArr) {
                    CodabarCharacter codabar = GetCharacterProperties(c);
                    DrawCharacterBars(codabar.Bars, codabar.Spaces);

                    // Add a Space after Each Character
                    xn += OneLineWidth;
                }

                // Draw the End Sentinal
                CodabarCharacter.n endSentinal = new CodabarCharacter.n();
                DrawCharacterBars(endSentinal.Bars, endSentinal.Spaces);

                //// Add a Space after Each Character
                //xn += OneLineWidth;
            }

            try {
                bcImg.Save(@"C:\Path\To\Images\" + DateTime.Now.Ticks.ToString() + ".png", ImageFormat.Png);
            } catch (Exception e) {
                return false;
            }

            return true;
        }

        private static void DrawCharacterBars(int[] bars, int[] spaces) {
            for (int i = 0; i < bars.Length; i++) {

                // Test Line-by-Line
                //if (i > 0)
                //    break;
                
                if (bars[i] == 0) {
                    g.DrawLine(p1, xn, 0, xn, y);
                    xn += OneLineWidth;
                } else {
                    xn += 3;
                    g.DrawLine(p3, xn, 0, xn, y);
                    xn += ThreeLineWidth - 2;
                }

                // If within Spaces Array Length (3)
                if (i < spaces.Length) {
                    if (spaces[i] == 0) {
                        // Move 1 Right (Space)
                        xn += OneLineWidth;
                    } else {
                        // Move 3 Right (Spaces)
                        xn += ThreeLineWidth - 1;
                    }
                }
            }
        }

        private static CodabarCharacter GetCharacterProperties(char c) {
            switch (c) {
                case '0':
                    return new CodabarCharacter.Zero();
                case '1':
                    return new CodabarCharacter.One();
                case '2':
                    return new CodabarCharacter.Two();
                case '3':
                    return new CodabarCharacter.Three();
                case '4':
                    return new CodabarCharacter.Four();
                case '5':
                    return new CodabarCharacter.Five();
                case '6':
                    return new CodabarCharacter.Six();
                case '7':
                    return new CodabarCharacter.Seven();
                case '8':
                    return new CodabarCharacter.Eight();
                case '9':
                    return new CodabarCharacter.Nine();
                case '-':
                    return new CodabarCharacter.Dash();
                case '$':
                    return new CodabarCharacter.Dollar();
                case ':':
                    return new CodabarCharacter.Colon();
                case '/':
                    return new CodabarCharacter.ForwardSlash();
                case '.':
                    return new CodabarCharacter.Period();
                case '+':
                    return new CodabarCharacter.Plus();
                case 'a':
                    return new CodabarCharacter.a();
                case 'b':
                    return new CodabarCharacter.b();
                case 'c':
                    return new CodabarCharacter.c();
                case 'd':
                    return new CodabarCharacter.d();
                case 't':
                    return new CodabarCharacter.t();
                case 'n':
                    return new CodabarCharacter.n();
                case '*':
                    return new CodabarCharacter.Asterisk();
                case 'e':
                    return new CodabarCharacter.e();
                default:
                    return null;
            }
        }
    }
}
