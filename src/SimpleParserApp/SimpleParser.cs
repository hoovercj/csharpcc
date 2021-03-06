// Generated By:CSharpCC: Do not edit this line. SimpleParser.cs
namespace Deveel.CSharpCC.Parser {


using System;

public class SimpleParser : SimpleParserConstants {

   public void Input() {
  Token t; string line;
    cc_consume_token(READ);
    cc_consume_token(AND);
    cc_consume_token(PRINT);
    t = cc_consume_token(STRING_LITERAL);
                                            line = t.Image;
    cc_consume_token(0);
  Console.Out.WriteLine(line);
  }

  /** Generated Token Manager. */
  public  SimpleParserTokenManager tokenSource;
  SimpleCharStream cc_inputStream;
  /// <summary>Current token.</summary>
  public Token token;
  /// <summary> Next token.</summary>
  public Token cc_nt;
  private int cc_ntKind;
  private int cc_gen;
   private readonly int[] cc_la1 = new int[0];
  static private int[] cc_la1_0;
  static SimpleParser() { 
      cc_la1_init_0();
   }
   private static void cc_la1_init_0() {
      cc_la1_0 = new int[] {};
   }

  /// Constructor with Stream.
  public SimpleParser(System.IO.Stream stream)
     : this(stream, null) {
  }
  /// Constructor with Stream and supplied encoding
  public SimpleParser(System.IO.Stream stream, System.Text.Encoding encoding) {
    cc_inputStream = new SimpleCharStream(stream, encoding, 1, 1);
    tokenSource = new SimpleParserTokenManager(cc_inputStream);
    token = new Token();
    cc_ntKind = -1;
    cc_gen = 0;
    for (int i = 0; i < 0; i++) cc_la1[i] = -1;
  }

  /// Reinitialise.
  public void ReInit(System.IO.Stream stream) {
     ReInit(stream, null);
  }
  /// Reinitialise.
  public void ReInit(System.IO.Stream stream, System.Text.Encoding encoding) {
   cc_inputStream.ReInit(stream, encoding, 1, 1);
    tokenSource.ReInit(cc_inputStream);
    token = new Token();
    cc_ntKind = -1;
    cc_gen = 0;
    for (int i = 0; i < 0; i++) cc_la1[i] = -1;
  }

  /// Constructor.
  public SimpleParser(System.IO.TextReader reader) {
    cc_inputStream = new SimpleCharStream(reader, 1, 1);
    tokenSource = new SimpleParserTokenManager(cc_inputStream);
    token = new Token();
    cc_ntKind = -1;
    cc_gen = 0;
    for (int i = 0; i < 0; i++) cc_la1[i] = -1;
  }

  /// Reinitialise.
  public void ReInit(System.IO.TextReader reader) {
    cc_inputStream.ReInit(reader, 1, 1);
    tokenSource.ReInit(cc_inputStream);
    token = new Token();
    cc_ntKind = -1;
    cc_gen = 0;
    for (int i = 0; i < 0; i++) cc_la1[i] = -1;
  }

  /** Constructor with generated Token Manager. */
  public SimpleParser(SimpleParserTokenManager tm) {
    tokenSource = tm;
    token = new Token();
    cc_ntKind = -1;
    cc_gen = 0;
    for (int i = 0; i < 0; i++) cc_la1[i] = -1;
  }

  /** Reinitialise. */
  public void ReInit(SimpleParserTokenManager tm) {
    tokenSource = tm;
    token = new Token();
    cc_ntKind = -1;
    cc_gen = 0;
    for (int i = 0; i < 0; i++) cc_la1[i] = -1;
  }

  private Token cc_consume_token(int kind) {
    Token oldToken;
    if ((oldToken = token).Next != null) token = token.Next;
    else token = token.Next = tokenSource.GetNextToken();
    cc_ntKind = -1;
    if (token.Kind == kind) {
      cc_gen++;
      return token;
    }
    token = oldToken;
    cc_kind = kind;
    throw GenerateParseException();
  }


/** Get the next Token. */
   public Token GetNextToken() {
    if (token.Next != null) token = token.Next;
    else token = token.Next = tokenSource.GetNextToken();
    cc_ntKind = -1;
    cc_gen++;
    return token;
  }

/** Get the specific Token. */
   public Token GetToken(int index) {
    Token t = token;
    for (int i = 0; i < index; i++) {
      if (t.Next != null) t = t.Next;
      else t = t.Next = tokenSource.GetNextToken();
    }
    return t;
  }

  private int cc_ntk() {
    if ((cc_nt=token.Next) == null)
      return (cc_ntKind = (token.Next = tokenSource.GetNextToken()).Kind);
    else
      return (cc_ntKind = cc_nt.Kind);
  }

  private System.Collections.Generic.IList<int[]> cc_expentries = new System.Collections.Generic.List<int[]>();
  private int[] cc_expentry;
  private int cc_kind = -1;

  /** Generate ParseException. */
  public ParseException GenerateParseException() {
    cc_expentries.Clear();
    bool[] la1tokens = new bool[9];
    if (cc_kind >= 0) {
      la1tokens[cc_kind] = true;
      cc_kind = -1;
    }
    for (int i = 0; i < 0; i++) {
      if (cc_la1[i] == cc_gen) {
        for (int j = 0; j < 32; j++) {
          if ((cc_la1_0[i] & (1<<j)) != 0) {
            la1tokens[j] = true;
          }
        }
      }
    }
    for (int i = 0; i < 9; i++) {
      if (la1tokens[i]) {
        cc_expentry = new int[1];
        cc_expentry[0] = i;
        cc_expentries.Add(cc_expentry);
      }
    }
    int[][] exptokseq = new int[cc_expentries.Count][];
    for (int i = 0; i < cc_expentries.Count; i++) {
      exptokseq[i] = cc_expentries[i];
    }
    return new ParseException(token, exptokseq, TokenImage);
  }

  /** Enable tracing. */
  public void enable_tracing() {
  }

  /** Disable tracing. */
  public void disable_tracing() {
  }

}
}
