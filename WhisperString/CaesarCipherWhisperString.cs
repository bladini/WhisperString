///Author: Gabriel

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhisperString;

namespace WhisperString {
    public class CaesarCipherWhisperString : IWhisperString {
        private char[] _table = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k',
                                  'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w',
                                  'z', 'å', 'ä', 'ö' };

        public CaesarCipherWhisperString() {
            Offset = 3;
        }

        public CaesarCipherWhisperString(int offset) {
            Offset = offset;
        }

        public int Offset { get; set; }

        public string ManipulateMessage(string message) {
            return message == null ? null
                : String.Join("", message.GroupBy(Char.IsLetter).SelectMany(letter => {
                    if (!letter.Key)
                        return letter.Select(c => c);
                    else
                        return letter.Select(c => {
                            var l = Array.IndexOf(_table, c);
                            int x = l + Offset;
                            x = x > 29 ? x - 29 : x;
                            return _table[x];
                        });
                }));
        }
    }
}

