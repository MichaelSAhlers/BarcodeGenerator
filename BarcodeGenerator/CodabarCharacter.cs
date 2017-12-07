namespace BarcodeGenerator {
    public class CodabarCharacter {
        public char Name { get; set; }
        public int[] Bars { get; set; }
        public int[] Spaces { get; set; }

        public class Zero : CodabarCharacter {
            public Zero() {
                Name = '0';
                Bars = new int[4] { 0, 0, 0, 1 };
                Spaces = new int[3] { 0, 0, 1 };
            }
        }
        public class One : CodabarCharacter {
            public One() {
                Name = '0';
                Bars = new int[4] { 0, 0, 1, 0 };
                Spaces = new int[3] { 0, 0, 1 };
            }
        }
        public class Two : CodabarCharacter {
            public Two() {
                Name = '0';
                Bars = new int[4] { 0, 0, 0, 1 };
                Spaces = new int[3] { 0, 1, 0 };
            }
        }
        public class Three : CodabarCharacter {
            public Three() {
                Name = '0';
                Bars = new int[4] { 1, 0, 0, 0 };
                Spaces = new int[3] { 1, 0, 0 };
            }
        }
        public class Four : CodabarCharacter {
            public Four() {
                Name = '0';
                Bars = new int[4] { 0, 1, 0, 0 };
                Spaces = new int[3] { 0, 0, 1 };
            }
        }
        public class Five : CodabarCharacter {
            public Five() {
                Name = '0';
                Bars = new int[4] { 1, 0, 0, 0 };
                Spaces = new int[3] { 0, 0, 1 };
            }
        }
        public class Six : CodabarCharacter {
            public Six() {
                Name = '0';
                Bars = new int[4] { 0, 0, 0, 1 };
                Spaces = new int[3] { 1, 0, 0 };
            }
        }
        public class Seven : CodabarCharacter {
            public Seven() {
                Name = '0';
                Bars = new int[4] { 0, 0, 1, 0 };
                Spaces = new int[3] { 1, 0, 0 };
            }
        }
        public class Eight : CodabarCharacter {
            public Eight() {
                Name = '0';
                Bars = new int[4] { 0, 1, 0, 0 };
                Spaces = new int[3] { 1, 0, 0 };
            }
        }
        public class Nine : CodabarCharacter {
            public Nine() {
                Name = '0';
                Bars = new int[4] { 1, 0, 0, 0 };
                Spaces = new int[3] { 0, 1, 0 };
            }
        }
        public class Dash : CodabarCharacter {
            public Dash() {
                Name = '0';
                Bars = new int[4] { 0, 0, 1, 0 };
                Spaces = new int[3] { 0, 1, 0 };
            }
        }
        public class Dollar : CodabarCharacter {
            public Dollar() {
                Name = '0';
                Bars = new int[4] { 0, 1, 0, 0 };
                Spaces = new int[3] { 0, 1, 0 };
            }
        }
        public class Colon : CodabarCharacter {
            public Colon() {
                Name = '0';
                Bars = new int[4] { 1, 0, 1, 1 };
                Spaces = new int[3] { 0, 0, 0 };
            }
        }
        public class ForwardSlash : CodabarCharacter {
            public ForwardSlash() {
                Name = '0';
                Bars = new int[4] { 1, 1, 0, 1 };
                Spaces = new int[3] { 0, 0, 0 };
            }
        }
        public class Period : CodabarCharacter {
            public Period() {
                Name = '0';
                Bars = new int[4] { 1, 1, 1, 0 };
                Spaces = new int[3] { 0, 0, 0 };
            }
        }
        public class Plus : CodabarCharacter {
            public Plus() {
                Name = '+';
                Bars = new int[4] { 0, 1, 1, 1 };
                Spaces = new int[3] { 0, 0, 0 };
            }
        }
        public class a : CodabarCharacter {
            public a() {
                Name = 'a';
                Bars = new int[4] { 0, 1, 0, 0 };
                Spaces = new int[3] { 0, 1, 1 };
            }
        }
        public class b : CodabarCharacter {
            public b() {
                Name = 'b';
                Bars = new int[4] { 0, 0, 0, 1 };
                Spaces = new int[3] { 1, 1, 0 };
            }
        }
        public class c : CodabarCharacter {
            public c() {
                Name = 'c';
                Bars = new int[4] { 0, 0, 0, 1 };
                Spaces = new int[3] { 0, 1, 1 };
            }
        }
        public class d : CodabarCharacter {
            public d() {
                Name = 'd';
                Bars = new int[4] { 0, 0, 1, 0 };
                Spaces = new int[3] { 0, 1, 1 };
            }
        }
        public class t : CodabarCharacter {
            public t() {
                Name = 't';
                Bars = new int[4] { 0, 1, 0, 0 };
                Spaces = new int[3] { 0, 1, 1 };
            }
        }
        public class n : CodabarCharacter {
            public n() {
                Name = 'n';
                Bars = new int[4] { 0, 0, 0, 1 };
                Spaces = new int[3] { 1, 1, 0 };
            }
        }
        public class Asterisk : CodabarCharacter {
            public Asterisk() {
                Name = '*';
                Bars = new int[4] { 0, 0, 0, 1 };
                Spaces = new int[3] { 0, 1, 1 };
            }
        }
        public class e : CodabarCharacter {
            public e() {
                Name = 'e';
                Bars = new int[4] { 0, 0, 1, 0 };
                Spaces = new int[3] { 0, 1, 1 };
            }
        }
    }
}
