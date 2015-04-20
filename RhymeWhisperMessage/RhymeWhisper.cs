using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using WhisperMessage;

namespace RhymeWhisperMessage
{
    class Word
    {
        public string Form { get; set; }
        public string Pronunciation { get; set; }
        public string Pos { get; set; }
        public string LastSyllable { get; set; }

        public Word(string form, string pronunciation, string pos)
        {
            this.Form = form;
            this.Pronunciation = pronunciation;
            this.Pos = pos;
            LastSyllable = Pronunciation.Remove(0, Math.Max(0, Pronunciation.Length - 4));
        }
    }

    public class RhymeWhisper : IWhisperString
    {
        public string ManipulateMessage(string message)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-us");

            if (String.IsNullOrEmpty(message))
                return message;
            else if (message.Trim() == String.Empty)
                return message;

            string output = String.Empty;

            string url = "http://netdev.kodalagom.se/upload/words.xml";
            XDocument doc = XDocument.Load(url);
            XElement[] elements = doc.Descendants("entry").ToArray();

            List<Word> lexicon = new List<Word>();
            List<Word> messageWords = new List<Word>();
            StringBuilder sb = new StringBuilder();

            foreach (var entry in elements)
            {
                lexicon.Add(new Word(entry.Descendants("form").First().Value,
                                   entry.Descendants("pronunciation").First().Value,
                                   entry.Descendants("pos").First().Value));
            }

            foreach (var w in message.Split(' '))
            {
                foreach (var c in w)
                {
                    if (!char.IsPunctuation(c))
                        sb.Append(c);
                }

                Word word = lexicon.SingleOrDefault(x => String.Equals(x.Form, sb.ToString().ToLower()));
                sb.Clear();

                if (word != null)
                    messageWords.Add(word);
                else
                    messageWords.Add(new Word(w, string.Empty, string.Empty));
            }

            if (messageWords.Count > 0 && messageWords.Last() == null)
                return message;

            Word[] matches = lexicon.Where(r => r.LastSyllable == messageWords.Last().LastSyllable && r.Form != messageWords.Last().Form && r.Pos != "förk.").ToArray();

            Random random = new Random();
            List<string> outputWords = new List<string>();

            foreach (var w in messageWords)
            {
                outputWords.Add(w.Form);
            }

            if (matches.Length > 0)
                outputWords[outputWords.Count - 1] = matches[random.Next(0, matches.Length - 1)].Form;

            output = String.Join(" ", outputWords);

            return output;
        }
    }
}
