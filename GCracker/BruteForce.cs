using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Timers;
using ICSharpCode.SharpZipLib.Zip;

namespace GCracker
{
    class BruteForce
    {
        public static char[] ALPHABET = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        public static char[] ALPHABET_UPPER = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        public static char[] ALPHABET_UPPER_NUMBER = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();

        public Form1 Parent { get; set; }

        static char[] Alphabet;

        static double KB = 1_000;
        static double MB = 1_000_000;
        static double GB = 1_000_000_000;
        static double TB = 1_000_000_000_000;

        static StringBuilder tmp;
        string curPass = "";
        static uint count = 0;
        double c = 0;



        static Timer tmr;


        public void Init()
        {
            tmr = new Timer();
            tmr.Interval = 1000;
            tmr.Start();
            tmr.Elapsed += ElapsedTick;
        }

        public void ElapsedTick(object sender, ElapsedEventArgs e)
        {
            Parent.UpdateLabelPassword((tmp != null) ? tmp.ToString() : "", count.ToString(), c.ToString());
            count = 0;
        }

        public string ArchiveBruteForce(ZipFile file)
        {
            Init();
            string pass = Alphabet[0].ToString();
            double limite = 1_000;
            tmp = new StringBuilder(pass);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (true)
            {
                for (int i = 0; i < Alphabet.Length; i++)
                {
                RETRY:
                    tmp = CheckPassWordLetter(tmp);
                    count++;
                    file.Password = tmp.ToString();
                    file.UseZip64 = UseZip64.Dynamic;
                    file.BeginUpdate();
                    file.CommitUpdate();




                    foreach (ZipEntry item in file)
                    {
                        String entryFileName = item.Name;
                        byte[] buffer = new byte[4096];
                        string outputFold = Environment.CurrentDirectory + "\\tmp";
                        FastZip zip = new FastZip();
                        zip.Password = tmp.ToString();
                        c++;
                        try
                        {
                            zip.ExtractZip(file.Name, outputFold, null);
                        }
                        catch (ZipException zex)
                        {
                            goto RETRY;
                        }
                        catch (Exception ex)
                        {
                            goto RETRY;
                        }
                        Parent.PasswordFound.Set();
                        return tmp.ToString();
                    }

                }

            }

            return null;
        }


        public static StringBuilder CheckPassWordLetter(StringBuilder pass)
        {
            int Turn = 1;
            for (int i = 0; i < Turn; i++)
            {
                if (pass[i] == Alphabet[Alphabet.Length - 1])
                {
                    if (pass.Length > i + 1)
                    {
                        pass[i] = Alphabet[0];
                        Turn++;
                    }
                    else
                    {
                        pass.Insert(0, Alphabet[0]);
                        pass[pass.Length - 1] = Alphabet[0];
                    }

                }
                else
                {
                    pass[i] = NewCharFromChar(pass[i]);
                }
            }
            return pass;
        }

        public static char NewCharFromChar(char letter)
        {
            for (int i = 0; i < Alphabet.Length; i++)
            {
                if (letter == Alphabet[i])
                {
                    if ((i + 1) > Alphabet.Length - 1)
                        return Alphabet[0];
                    else
                        return Alphabet[i + 1];
                }
            }

            return new char();
        }






        public string ToNormalize(double value)
        {
            string msg = string.Empty;
            if (value > KB && value < MB)
            {
                value /= KB;
                msg = " KB";
            }
            else if (value > MB && value < GB)
            {
                value /= MB;
                msg = " MB";

            }
            else if (value > GB && value < TB)
            {
                value /= GB;
                msg = " GB";

            }

            return $"{value}{msg}";

        }


        public BruteForce(Form1 parent,int alphaNumber)
        {
            this.Parent = parent;
            switch (alphaNumber)
            {
                case 1:
                    Alphabet = ALPHABET;
                    break;
                case 2:
                    Alphabet = ALPHABET_UPPER;
                    break;
                case 3:
                    Alphabet = ALPHABET_UPPER_NUMBER;
                    break;
                default:
                    Alphabet = ALPHABET_UPPER_NUMBER;
                    break;
            }
        }



    }
}
