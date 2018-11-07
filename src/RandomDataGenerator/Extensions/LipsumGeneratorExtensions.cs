using NLipsum.Core;

namespace RandomDataGenerator.Extensions
{
    public static class LipsumGeneratorExtensions
    {
        public static string GenerateWord(this LipsumGenerator generator)
        {
            return generator.GenerateWords(1)[0];
        }
    }
}