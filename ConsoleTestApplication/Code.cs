namespace ConsoleTestApplication
{
    public class Code : ICode
    {
        public string GenerateCode(bool extraversion, bool sensing, bool thinking, bool judging)
        {
            string code = string.Empty;

            if (extraversion)
                code += "E";

            else
                code += "I";


            if (sensing)
                code += "S";

            else
                code += "N";

            if (thinking)
                code += "T";

            else
                code += "F";

            if (judging)
                code += "J";

            else
                code += "P";

            return code;
        }
    }
}
