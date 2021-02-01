using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using NLog;


public class AppUtil
{
    private static Logger logger = LogManager.GetCurrentClassLogger();
    //private static Random random = new Random();
    private static readonly object syncLock = new object();
    public AppUtil()
    {
        
    }

    public static void Log(string s)
    {
        System.Diagnostics.Debug.Write("==> " + s + '\n');

        //Log to file
        logger.Info(s);
    }

    public static string TokenGenerator()
    {
        return Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Substring(0, 20);
    }

    // Cryptography
    public static string CalculateMD5Hash(string input)
    {
        // step 1, calculate MD5 hash from input
        MD5 md5 = System.Security.Cryptography.MD5.Create();
        byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
        byte[] hash = md5.ComputeHash(inputBytes);
        // step 2, convert byte array to hex string
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < hash.Length; i++)
        {
            sb.Append(hash[i].ToString("X2"));
        }
        return sb.ToString().ToUpper();
    }
    public static string GetRandomString(int length)
    {
        Random random = new Random();
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        return new string(Enumerable.Repeat(chars, length)
          .Select(s => s[random.Next(s.Length)]).ToArray());
    }

    public static string GetRandomVinaSDT()
    {
        Random random = new Random();
        int r = 0;
        lock (syncLock)
        {
            r = random.Next(0, 9);
        }   
        if (r % 2 == 0)
            r = 0;
        else
            r = 0;
        return "849" + r + AppUtil.GetRandomNumbers(7);
    }

    public static string GetRandomValidSDT()
    {
        Random random = new Random();
        int r = 0;
        do
        {
            lock (syncLock)
            {
                r = int.Parse(RandomNumber(1));
            }
                
        } while (r == 5);
        return "849" +r+ AppUtil.GetRandomNumbers(7);
    }
    private static Random random = new Random();
    public static string RandomNumber(int length)
    {
        const string chars = "02356789";
        return new string(Enumerable.Repeat(chars, length)
          .Select(s => s[random.Next(s.Length)]).ToArray());
    }

    public static string GetRandomNumbers(int length)
    {   // ok
        Random random = new Random();
        if (length <= 0)
            return string.Empty;
        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
        {
            //lock (syncLock)
                arr[i] = random.Next(0, 9);
        }
        return String.Join(string.Empty, arr);
    }

    public static string GetCurrentTicksString()
    {
        long time = DateTime.Now.Ticks;
        return Convert.ToString(time);
    }
}
