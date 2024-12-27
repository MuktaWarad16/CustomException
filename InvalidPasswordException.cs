using System;

class InvalidPasswordException : Exception
{
    public InvalidPasswordException(string str)
    {
        Console.WriteLine("undefined exception");
    }

    public static void meth2()
    {
        try
        {
            throw new InvalidPasswordException("wrong password");

        }
        catch (InvalidPasswordException e)
        {
            Console.WriteLine("wrong password");
        }


    }
}