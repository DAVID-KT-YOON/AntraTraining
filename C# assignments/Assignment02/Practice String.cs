using System.Text;

namespace Assignment02;

public class Practice_String
{
    public String Q1_a(String str)
    {
        char[] arr = str.ToCharArray();
        for (int i = 0; i < arr.Length / 2; i++)
        {
            char temp = arr[i];
            arr[i] = arr[arr.Length - i - 1];
            arr[arr.Length - i - 1] = temp;
        }

        return arr.ToString();
    } 
    public String Q1_b(String str)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = str.Length - 1; i >= 0; i--)
        {
            sb.Append(str[i]);
            
        }

        return sb.ToString();
    }

    public String Q2(String str)
    {
        List<String> tokens = new List<String>();
        List<String> words = new List<String>();
        StringBuilder sb = new StringBuilder();
        char[] seps = { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };

        foreach (char c in str)
        {
            if (!seps.Contains(c) && c != ' ')
            {
                sb.Append(c);
            }
            else
            {
                tokens.Add(sb.ToString());
                tokens.Add(c.ToString());
                sb.Clear();
            }
        }
        if (sb.Length > 0)
        {
            tokens.Add(sb.ToString());
            sb.Clear();
        }

        foreach (String token in tokens)
        {
            if (string.IsNullOrEmpty(token)) 
                continue;
            if (seps.Contains(token[0]) || token[0] == ' ')
            {
                continue;
            }
            words.Add(token);
        }

        words.Reverse();
        int x = 0;
        for (int i = 0; i < tokens.Count; i++)
        {
            if (string.IsNullOrEmpty(tokens[i])) 
                continue;
            if (seps.Contains(tokens[i][0]) || tokens[i][0] == ' ')
            {
                sb.Append(tokens[i]);
                continue;
            }
            sb.Append(words[x++]);
         
        }

        return sb.ToString();

    }
    public String Q3(String str)
    {
        char[] seps = { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };
        string[] parts = str.Split(seps);
        List<String> list = new List<String>();

        foreach (string part in parts)
        {
            bool isPalindrome = true;
            for (int i = 0; i < part.Length / 2; i++)
            {
                if (part[i] != part[part.Length - i - 1])
                {
                    isPalindrome = false;
                }
            }

            if (isPalindrome)
            {
                list.Add(part);
            }

            
        }
        return string.Join(", ", list);
    }

    public void Q4(String str)
    {
        String protocol = "";
        String server = "";
        String resource = "";
        int protocolCheck = str.IndexOf("://");
        if (protocolCheck != -1)
        {
            protocol = str.Substring(0, protocolCheck);
            str = str.Substring(protocolCheck + 3);
        }

        int resourceCheck = str.IndexOf("/");
        if (resourceCheck != -1)
        {
            resource = str.Substring(resourceCheck + 1);
            str = str.Substring(0 , resourceCheck);
        }

        server = str;

    }
}