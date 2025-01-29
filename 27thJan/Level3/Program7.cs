using System;

public class OTPGenerator
{
    // method to generate a 6-digit OTP number
    public static int GenerateOTP()
    {
        Random random = new Random();
        // generating a 6-digit number between 100000 and 999999
        int otp = random.Next(100000, 1000000);
        return otp;
    }

    // method to ensure the generated OTPs are unique
    public static bool AreUniqueOTPs(int[] otps)
    {
        for (int i = 0; i < otps.Length; i++)
        {
            for (int j = i + 1; j < otps.Length; j++)
            {
                if (otps[i] == otps[j]) // duplicate OTP found
                {
                    return false;
                }
            }
        }
        return true;
    }

    public static void Main(string[] args)
    {
        // array to store 10 OTP numbers
        int[] otps = new int[10];

        // generate 10 OTPs
        for (int i = 0; i < 10; i++)
        {
            otps[i] = GenerateOTP();
            Console.WriteLine("Generated OTP " + (i + 1) + ": " + otps[i]);
        }

        // check if the OTPs are unique
        bool isUnique = AreUniqueOTPs(otps);

        // display the result
        if (isUnique)
        {
            Console.WriteLine("All OTPs are unique.");
        }
        else
        {
            Console.WriteLine("Some OTPs are not unique.");
        }
    }
}
