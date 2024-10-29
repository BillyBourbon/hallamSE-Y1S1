class BadCipher
{

    public static string Encrypt( string text, int difference = 1 )
    {
        string modifiedText = "";

        foreach ( char letter in text )
        {
            modifiedText = $"{ ShiftLetter(letter, difference) }{ modifiedText }";
        }
        
        modifiedText = $"{ modifiedText.Substring(1) }{ modifiedText.First().ToString() }";
    
        return modifiedText;
    }
    
    public static string Decrypt( string modifiedText, int difference)
    {
        string text = "";
        
        foreach ( char letter in modifiedText )
        {
            text = $"{ ShiftLetter(letter, difference) }{ text }";
        }
        
        text = $"{ text.Substring(1, text.Length - 1) }{ text.First().ToString() }";
        
        return text;
    }

    private static char ShiftLetter( char letter, int difference = 1)
    {
        if( char.IsWhiteSpace(letter) ) return letter;
        
        if ( letter == 'z' ) 
        {
            letter = 'a'; 
            difference--;
        }
        
        int letterAsInt = (int)letter ;
        char shiftedChar = (char)(letterAsInt + difference);
        
        //Console.WriteLine( $"Input Char: {letter}, LetterAsInt: {letterAsInt}, Difference: {difference}, Output Char: {shiftedChar}" );
        
        return shiftedChar;
    }

}
