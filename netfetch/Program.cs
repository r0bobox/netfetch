namespace netfetch;

class Program
{
    static void Main(string[] args)
    {
        // define strings and a char
        string userName = Environment.UserName;
        string computerName = Environment.MachineName;
        string domainName = Environment.UserDomainName;
        string systemVersion = Environment.OSVersion.ToString();
        string upTime = (Environment.TickCount64 / 1000).ToString();
        string threadCount = Environment.ProcessorCount.ToString();
        string cpuBitness = "";
        if (Environment.Is64BitOperatingSystem == true) { cpuBitness = "64-bit"; }
        else { cpuBitness = "32-bit"; }
        string clrBitness = "";
        if (Environment.Is64BitProcess == true) { clrBitness = "64-bit"; }
        else { clrBitness = "32-bit"; }
        string clrVersion = Environment.Version.ToString();
        int lineLength = (userName + computerName + 1).Length;
        char lineSeperator = '-';
        
        
        // print strings in screenfetch-esque manner
        if (computerName != domainName)
        {
            lineLength = (userName + computerName + domainName + 1).Length;
            Console.WriteLine($"{userName}@{computerName}.{domainName}");
        }
        else { Console.WriteLine($"{userName}@{computerName}"); }
        string seperationLine = new string(lineSeperator, lineLength);
        Console.WriteLine(seperationLine);
        Console.WriteLine($"OS: {systemVersion}");
        Console.WriteLine($"Uptime: {upTime} seconds");
        Console.WriteLine($"CPU: {cpuBitness} processor with {threadCount} threads");
        Console.WriteLine($"CLR: {clrVersion} {clrBitness}");
    }
}