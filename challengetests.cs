using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ChallengeTest
{
    public static class StringExtensions
    {
        public static bool IsPalindrome(this string str)
        {
            string cleanedString = CleanUpString(str);

            string reverseStr = cleanedString.Reverse();

            return (string.Compare(reverseStr, cleanedString, true) == 0);
        }

        public static string CleanUpString(string str)
        {
            List<char> chars = str.ToCharArray().ToList();
            chars.RemoveAll(c => char.IsPunctuation(c) || char.IsSeparator(c));
            var cleanedString = new string(chars.ToArray());
            return cleanedString;
        }

        public static string Reverse(this string str)
        {
            var array = str.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckThatReverseStringWorks()
        {
            Assert.AreEqual("abba", "abba".Reverse());
            Assert.AreEqual("daniel", "leinad".Reverse());
            Assert.AreEqual("josh", "hsoj".Reverse());
            Assert.AreEqual("st. vicent", "tneciv .ts".Reverse());
        }
        [TestMethod]
        public void CheckValidPalindrome()
        {
            var testphrases =
            new[]{
            "A but tuba.",
            "A car, a man, a maraca.",
            "A dog, a plan, a canal: pagoda.",
            "A dog! A panic in a pagoda!",
            "A lad named E. Mandala",
            "A man, a plan, a canal: Panama.",
            "A man, a plan, a cat, a ham, a yak, a yam, a hat, a canal-Panama!",
            "A new order began, a more Roman age bred Rowena.",
            "A nut for a jar of tuna.",
            "A Santa at Nasa.",
            "A Santa dog lived as a devil God at NASA.",
            "A slut nixes sex in Tulsa.",
            "A tin mug for a jar of gum, Nita.",
            "A Toyota! Race fast, safe car! A Toyota!",
            "A Toyota’s a Toyota.",
            "Able was I ere I saw Elba.",
            "Acrobats stab orca.",
            "Aerate pet area.",
            "Ah, Satan sees Natasha!",
            "Aibohphobia",
            "Air an aria.",
            "Al lets Della call Ed Stella.",
            "alula",
            "Amen icy cinema.",
            "Amore, Roma.",
            "Amy, must I jujitsu my ma?",
            "Ana",
            "Animal loots foliated detail of stool lamina.",
            "Anna",
            "Anne, I vote more cars race Rome to Vienna.",
            "Are Mac ‘n’ Oliver ever evil on camera?",
            "Are we not drawn onward to new era?",
            "Are we not drawn onward, we few, drawn onward to new era?",
            "Are we not pure? “No sir!” Panama’s moody Noriega brags. “It is garbage!” Irony dooms a man; a prisoner up to new era.",
            "Art, name no tub time. Emit but one mantra.",
            "As I pee, sir, I see Pisa!",
            "Avid diva.",
            "Avid***diva..."
            };

            foreach (var phrase in testphrases)
            {
                bool result = phrase.IsPalindrome();
                Assert.IsTrue(result, $"Phrase was: {phrase}");
            }
           
        }

        [TestMethod]
        public void CheckInValidPalindrome()
        {
            bool result = "dog".IsPalindrome();
            Assert.IsFalse(result);
        }
    }
}
