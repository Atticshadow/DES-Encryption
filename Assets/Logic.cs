using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class Logic : MonoBehaviour {

    public InputField Message;
    public InputField Key;
    public Text Output;

    string message;
    string key;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ConvertClick()
    {
        message = Message.text;
        key = Key.text;
        Main();
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Main()     {         DESLogic.MainClass DES = new DESLogic.MainClass();         string binString = DES.StringToBinary(message);         string binKey = DES.StringToBinary(key);         DES.AssignMessageValues(binString);         DES.AssignKeyValues(binKey);         DES.IntitialPermutation();         DES.PermutedChoiceOne();         //Console.WriteLine(DES.ip33 + "" + DES.ip34 + "" + DES.ip35 + "" + DES.ip36 + "" + DES.ip37 + "" + DES.ip38 + "" + DES.ip39 + "" + DES.ip40         // + "" + DES.ip41 + "" + DES.ip42 + "" + DES.ip43 + "" + DES.ip44 + "" + DES.ip45 + "" + DES.ip46 + "" + DES.ip47 + "" + DES.ip48         // + "" + DES.ip49 + "" + DES.ip50 + "" + DES.ip51 + "" + DES.ip52 + "" + DES.ip53 + "" + DES.ip54 + "" + DES.ip55 + "" + DES.ip56         // + "" + DES.ip57 + "" + DES.ip58 + "" + DES.ip59 + "" + DES.ip60 + "" + DES.ip61 + "" + DES.ip62 + "" + DES.ip63 + "" + DES.ip64);         for (int i = 1; i < 17; i++)         {             DES.getOldR(i);             //Console.WriteLine(DES.ip1 + "" + DES.ip2 + "" + DES.ip3 + "" + DES.ip4 + "" + DES.ip5 + "" + DES.ip6 + "" + DES.ip7 + "" + DES.ip8             // + "" + DES.ip9 + "" + DES.ip10 + "" + DES.ip11 + "" + DES.ip12 + "" + DES.ip13 + "" + DES.ip14 + "" + DES.ip15 + "" + DES.ip16             // + "" + DES.ip17 + "" + DES.ip18 + "" + DES.ip19 + "" + DES.ip20 + "" + DES.ip21 + "" + DES.ip22 + "" + DES.ip23 + "" + DES.ip24             // + "" + DES.ip25 + "" + DES.ip26 + "" + DES.ip27 + "" + DES.ip28 + "" + DES.ip29 + "" + DES.ip30 + "" + DES.ip31 + "" + DES.ip32);             DES.ExpansionPermutation(i);             //Console.WriteLine(DES.e1 + "" + DES.e2 + "" + DES.e3 + "" + DES.e4 + "" + DES.e5 + "" + DES.e6             // + " " + DES.e43 + "" + DES.e44 + "" + DES.e45 + "" + DES.e46 + "" + DES.e47 + "" + DES.e48);             //Console.WriteLine(DES.c1 + "" + DES.c2 + "" + DES.c3 + "" + DES.c4 + "" + DES.c5 + "" + DES.c6 + "" + DES.c7);             DES.LShift(DES.lshifts[i]);             //Console.WriteLine(DES.c1 + "" + DES.c2 + "" + DES.c3 + "" + DES.c4 + "" + DES.c5 + "" + DES.c6 + "" + DES.c7);             DES.PermutedChoiceTwo();             //Console.WriteLine( DES.pct1 + "" + DES.pct2 + "" + DES.pct3 + "" + DES.pct4 + "" + DES.pct5 + "" + DES.pct6 + " " +             // DES.pct7 + "" + DES.pct8 + "" + DES.pct9 + "" + DES.pct10 + "" + DES.pct11 + "" + DES.pct12 + " " +             // DES.pct13 + "" + DES.pct14 + "" + DES.pct15 + "" + DES.pct16 + "" + DES.pct17 + "" + DES.pct18 + " " +             // DES.pct19 + "" + DES.pct20 + "" + DES.pct21 + "" + DES.pct22 + "" + DES.pct23 + "" + DES.pct24 + " " +             // DES.pct25 + "" + DES.pct26 + "" + DES.pct27 + "" + DES.pct28 + "" + DES.pct29 + "" + DES.pct30 + " " +             // DES.pct31 + "" + DES.pct32 + "" + DES.pct33 + "" + DES.pct34 + "" + DES.pct35 + "" + DES.pct36 + " " +             // DES.pct37 + "" + DES.pct38 + "" + DES.pct39 + "" + DES.pct40 + "" + DES.pct41 + "" + DES.pct42 + " " +             // DES.pct43 + "" + DES.pct44 + "" + DES.pct45 + "" + DES.pct46 + "" + DES.pct47 + "" + DES.pct48);             DES.XOREnPC2();             //Console.WriteLine(DES.x1 + "" + DES.x2 + "" + DES.x3 + "" + DES.x4 + "" + DES.x5 + "" + DES.x6             // + " " + DES.x43 + "" + DES.x44 + "" + DES.x45 + "" + DES.x46 + "" + DES.x47 + "" + DES.x48);             DES.SBox1();             DES.SBox2();             DES.SBox3();             DES.SBox4();             DES.SBox5();             DES.SBox6();             DES.SBox7();             DES.SBox8();             DES.Permutation();             //Console.WriteLine(DES.p1 + "" + DES.p2 + "" + DES.p3 + "" + DES.p4 + " " + DES.p29 + "" + DES.p30 + "" + DES.p31 + "" + DES.p32);             DES.XORPermnL(i);             DES.MakeNewL(i);             string rbin = DES.nr1 + "" + DES.nr2 + "" + DES.nr3 + "" + DES.nr4 + "" + DES.nr5 + "" + DES.nr6 + "" + DES.nr7 + "" + DES.nr8 + "" +             DES.nr9 + "" + DES.nr10 + "" + DES.nr11 + "" + DES.nr12 + "" + DES.nr13 + "" + DES.nr14 + "" + DES.nr15 + "" + DES.nr16 + "" +             DES.nr17 + "" + DES.nr18 + "" + DES.nr19 + "" + DES.nr20 + "" + DES.nr21 + "" + DES.nr22 + "" + DES.nr23 + "" + DES.nr24 + "" +             DES.nr25 + "" + DES.nr26 + "" + DES.nr27 + "" + DES.nr28 + "" + DES.nr29 + "" + DES.nr30 + "" + DES.nr31 + "" + DES.nr32;             string lbin = DES.nl1 + "" + DES.nl2 + "" + DES.nl3 + "" + DES.nl4 + "" + DES.nl5 + "" + DES.nl6 + "" + DES.nl7 + "" + DES.nl8 + "" +             DES.nl9 + "" + DES.nl10 + "" + DES.nl11 + "" + DES.nl12 + "" + DES.nl13 + "" + DES.nl14 + "" + DES.nl15 + "" + DES.nl16 + "" +             DES.nl17 + "" + DES.nl18 + "" + DES.nl19 + "" + DES.nl20 + "" + DES.nl21 + "" + DES.nl22 + "" + DES.nl23 + "" + DES.nl24 + "" +             DES.nl25 + "" + DES.nl26 + "" + DES.nl27 + "" + DES.nl28 + "" + DES.nl29 + "" + DES.nl30 + "" + DES.nl31 + "" + DES.nl32;             var hexl = BinaryStringToHexString(lbin);
            var hexr = BinaryStringToHexString(rbin);
            //Console.WriteLine(lbin + " " + rbin);
            //Console.WriteLine("L" + ": " + hexl + " R" + ": " + hexr);
        }         DES.FinalPermuation();         string finalbin = DES.fp1 + "" + DES.fp2 + "" + DES.fp3 + "" + DES.fp4 + "" + DES.fp5 + "" + DES.fp6 + "" + DES.fp7 + "" + DES.fp8 + "" +         DES.fp9 + "" + DES.fp10 + "" + DES.fp11 + "" + DES.fp12 + "" + DES.fp13 + "" + DES.fp14 + "" + DES.fp15 + "" + DES.fp16 + "" +         DES.fp17 + "" + DES.fp18 + "" + DES.fp19 + "" + DES.fp20 + "" + DES.fp21 + "" + DES.fp22 + "" + DES.fp23 + "" + DES.fp24 + "" +         DES.fp25 + "" + DES.fp26 + "" + DES.fp27 + "" + DES.fp28 + "" + DES.fp29 + "" + DES.fp30 + "" + DES.fp31 + "" + DES.fp32 + "" +         DES.fp33 + "" + DES.fp34 + "" + DES.fp35 + "" + DES.fp36 + "" + DES.fp37 + "" + DES.fp38 + "" + DES.fp39 + "" + DES.fp40 + "" +         DES.fp41 + "" + DES.fp42 + "" + DES.fp43 + "" + DES.fp44 + "" + DES.fp45 + "" + DES.fp46 + "" + DES.fp47 + "" + DES.fp48 + "" +         DES.fp49 + "" + DES.fp50 + "" + DES.fp51 + "" + DES.fp52 + "" + DES.fp53 + "" + DES.fp54 + "" + DES.fp55 + "" + DES.fp56 + "" +         DES.fp57 + "" + DES.fp58 + "" + DES.fp59 + "" + DES.fp60 + "" + DES.fp61 + "" + DES.fp62 + "" + DES.fp63 + "" + DES.fp64;
        var hexfinal = BinaryStringToHexString(finalbin);         string final = DES.BinaryToString(finalbin);         Output.text = hexfinal;         //Console.WriteLine(hexfinal);         //Console.WriteLine(final);     }

    public static string BinaryStringToHexString(string binary)
    {
        StringBuilder result = new StringBuilder(binary.Length / 8 + 1);

        int mod4Len = binary.Length % 8;
        if (mod4Len != 0)
        {
            binary = binary.PadLeft(((binary.Length / 8) + 1) * 8, '0');
        }

        for (int i = 0; i < binary.Length; i += 8)
        {
            string eightBits = binary.Substring(i, 8);
            result.AppendFormat("{0:X2}", Convert.ToByte(eightBits, 2));
        }

        return result.ToString();
    }
}
