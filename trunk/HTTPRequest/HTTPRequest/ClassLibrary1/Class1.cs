using System;
using System.Text;

namespace Parser
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	public class Parser
	{
		public	string[,] PLabels,PLinks;

		string [,]AsciiChar={{"&quot;","&#34;","\""},
					{"&apos;","&#39;","'"},
					{"&amp;","&#38;","&"},
					{"&lt;","&#60;","<"},
					{"&gt;","&#62;",">"},
					
								// ISO 8859-1 Symbol Entities
					{"&nbsp;","&#160;"," "},
					{"&iexcl;","&#161;","°"},		//--
					{"&curren;","&#164;","§"},	//-- 1 4 8
					{"&cent;","&#162;","¢"},		//--
					{"&pound;","#163;","£"},		//-- 1 5 6
					{"&yen;","&#165;","•"},		//--
					{"&brvbar;","&#166;","¶"},	//-- 
					{"&sect;","&#167;","ß"},		//-- 7 8 9
					{"&uml;","&#168;","®"},		//--
					{"&copy;","&#169;","©"},		//--
					{"&ordf;","&#170;","?"},		//--
					{"&laquo;","&#171;","´"},		//-- 1 7 4
					{"&not;","&#172;","¨"},		//--
					{"&shy;","&#173;","≠"},		//--
					{"&reg;","&#174;","Æ"},		//--
					{"&trade;","&#8482;","ô"},	//--
					{"&macr;","&#175;","Ø"},		//--
					{"&deg;","&#176;","∞"},		//--
					{"&plusmn;","&#177;","±"},	//--
					{"&sup2;","&#178;","≤"},		//--
					{"&sup3;","&#179;","≥"},		//--
					{"&acute;","&#180;","¥"},		//--
					{"&micro;","&#181;","µ"},		//-- 1 5 10
					{"&para;","&#182;","∂"},		//-- 2 0
					{"&middot;","&#183;","∑"},	//--
					{"&cedil;","&#184;","∏"},		//--
					{"&sup1;","&#185;","π"},		//--
					{"&ordm;","&#186;","∫"},		//--
					{"&raquo;","&#187;","ª"},		//-- 1 7 5
					{"&frac14;","&#188;","º"},	//--
					{"&frac12;","&#189;","Ω"},	//--
					{"&frac34;","&#190;","æ"},	//--
					{"&iquest;","&#191;","ø"},	//--
					{"&times;","&#215;","◊"},		//--	
					{"&divide;","&#247;","˜"},	//--

								// ISO 8859-1 Character Entities
					{"&Agrave;","&#192;","A"},
					{"&Aacute;","&#193;","?"},
					{"&Acirc;","&#194;","A"},
					{"&Atilde;","&#195;","?"},
					{"&Auml;","&#196;","?"},
					{"&Aring;","&#197;","?"},
					{"&AElig;","&#198;","?"},
					{"&Ccedil;","&#199;","C"},
					{"&Egrave;","&#200;","E"},
					{"&Eacute;","&#201;","E"},
					{"&Ecirc;","&#202;","E"},
					{"&Euml;","&#203;","E"},
					{"&Igrave;","&#204;","?"},
					{"&Iacute;","&#205;","?"},
					{"&Icirc;","&#206;","I"},
					{"&Iuml;","&#207;","I"},
					{"&ETH;","&#208;","?"},
					{"&Ntilde;","&#209;","?"},
					{"&Ograve;","&#210;","?"},
					{"&Oacute;","&#211;","?"},
					{"&Ocirc;","&#212;","O"},
					{"&Otilde;","&#213;","?"},
					{"&Ouml;","&#214;","?"},
					{"&Oslash;","&#216;","?"},
					{"&Ugrave;","&#217;","U"},
					{"&Uacute;","&#218;","?"},
					{"&Ucirc;","&#219;","U"},
					{"&Uuml;","&#220;","U"},
					{"&Yacute;","&#221;","?"},
					{"&THORN;","&#222;","?"},
					{"&szlig;","&#223;","?"},
					{"&agrave;","&#224;","‡"},
					{"&aacute;","&#225;","?"},
					{"&acirc;","&#226;","‚"},
					{"&atilde;","&#227;","?"},
					{"&auml;","&#228;","?"},
					{"&aring;","&#229;","?"},
					{"&aelig;","&#230;","?"},
					{"&ccedil;","&#231;","Á"},
					{"&egrave;","&#232;","Ë"},
					{"&eacute;","&#233;","È"},
					{"&ecirc;","&#234;","Í"},
					{"&euml;","&#235;","Î"},
					{"&igrave;","&#236;","?"},
					{"&iacute;","&#237;","?"},
					{"&icirc;","&#238;","Ó"},
					{"&iuml;","&#239;","Ô"},
					{"&eth;","&#240;","?"},
					{"&ntilde;","&#241;","?"},
					{"&ograve;","&#242;","?"},
					{"&oacute;","&#243;","?"},
					{"&ocirc;","&#244;","Ù"},
					{"&otilde;","&#245;","?"},
					{"&ouml;","&#246;","?"},
					{"&oslash;","&#248;","?"},
					{"&ugrave;","&#249;","˘"},
					{"&uacute;","&#250;","?"},
					{"&ucirc;","&#251;","˚"},
					{"&uuml;","&#252;","¸"},
					{"&yacute;","&#253;","?"},
					{"&thorn;","&#254;","?"},
					{"&yuml;","&#255;","?"},

								// Some Other Entities supported by HTML
					{"&OElig;","&#338;","å"},
					{"&oelig;","&#339;","ú"},
					{"&Scaron;","&#352;","?"},
					{"&scaron;","&#353;","?"},
					{"&Yuml;","&#376;","?"},
					{"&circ;","&#710;","à"},
					{"&tilde;","&#732;","?"},
					{"&ensp;","&#8194;","?"},
					{"&emsp;","&#8195;","?"},
					{"&thinsp;","&#8201;","?"},
					{"&zwnj;","&#8204;","ù"},
					{"&zwj;","&#8205;","û"},
					{"&lrm;","&#8206;",""},
					{"&rlm;","&#8207;",""},
					{"&ndash;","&#8211;","ñ"},
					{"&mdash;","&#8212;","ó"},
					{"&lsquo;","&#8216;","ë"},
					{"&rsquo;","&#8217;","í"},
					{"&sbquo;","&#8218;","Ç"},
					{"&ldquo;","&#8220;","ì"},
					{"&rdquo;","&#8221;","î"},
					{"&bdquo;","&#8222;","Ñ"},
					{"&dagger;","&#8224;","Ü"},
					{"&Dagger;","&#8225;","á"},
					{"&hellip;","&#8230;","Ö"},
					{"&permil;","&#8240;","â"},
					{"&lsaquo;","&#8249;","ã"},
					{"&rsaquo;","&#8250;","õ"},
					{"&euro;","&#8364;","Ä"}
					};
		public Parser()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		public string GetTitle(string Source)
		{
			int len=Source.Length;
			string title="      ";  
			char c;
			for(int i=0;i<len;i++)
			{
				c=Convert.ToChar(Source.Substring(i,1));
				title=title.Remove(0,1);
				title+=c;
				if(title.ToLower()=="<title")
				{
					while(c!='>')
					{
						i++;
						c=Convert.ToChar(Source.Substring(i,1));
					}
					title="";
					i++;
					c=Convert.ToChar(Source.Substring(i,1));
					while(c!='<')
					{
						title+=c;
						i++;
						c=Convert.ToChar(Source.Substring(i,1));
					}
					break;
				}
			}
			return title.Trim();
		}
		public string GetText(string Source)
		{
			int len=Source.Length,i;
			bool check=false;
			string s="",s1="",script="      ",style="     ";
			string filter="          "; // Ascii Chars
			string body="    ",title="      ";
			char c;
					//----------------- Title and Body
			for(i=0;i<len;i++) 
			{
				c=Convert.ToChar(Source.Substring(i,1));
				title+=c;
				if(title.ToLower()=="<title>") 
				{
					i++;
					c=Convert.ToChar(Source.Substring(i,1));
					while(c!='<') 
					{
						s+=c;
						i++;
						c=Convert.ToChar(Source.Substring(i,1));
					}
					while(c!='>') 
					{
						i++;
						c=Convert.ToChar(Source.Substring(i,1));
					}
					s+="\r\n";
				}
				else title=title.Remove(0,1);
				body+=c;
				if(body.ToLower()=="<body") 
				{
					while(c!='>') 
					{
						c=Convert.ToChar(Source.Substring(i,1));
						i++;
					}
					break;
				}
				body=body.Remove(0,1);
			}
			for( ;i<len;i++) 
			{
				c=Convert.ToChar(Source.Substring(i,1));
				//-------------- Java Script ---------------
				script+=c;
				if(script.ToLower()=="<script") 
				{
					script="         ";	i++;
					c=Convert.ToChar(Source.Substring(i,1));
					while(script.ToLower()!="</script>") 
					{
						i++;
						c=Convert.ToChar(Source.Substring(i,1));
						script=script.Remove(0,1);;
						script+=c;
					}
					s1="";	script="      ";
					continue;
				}
				else script=script.Remove(0,1);
				//------------------------------------------
				//--------------- Style --------------------
				style+=c;
				if(style.ToLower()=="<style") 
				{
					style="        ";	i++;
					c=Convert.ToChar(Source.Substring(i,1));
					while(style.ToLower()!="</style>") 
					{
						i++;
						c=Convert.ToChar(Source.Substring(i,1));
						style=style.Remove(0,1);
						style+=c;
					}
					s1="";	style="     "; check=true;
					continue;
				}
				else style=style.Remove(0,1);
				//------------------------------------------
				//----------------- &Ascii Char; -------------------
				filter+=c;
				if(c==';') 
				{
					int find;
					if((find=Find(filter,"&"))>=0) 
					{
						filter=filter.Remove(0,find);
						string res=FilterAscii(filter.Trim());
						if(res!="NULL") 
						{
							find =filter.Length-1;
							c=Convert.ToChar(res.Substring(res.Length-1,1));
							s=s.Remove(s.Length-find,find);
							filter="          ";
							s+=c;
							continue;
						}
					}
				}
				filter=filter.Remove(0,1);
				//------------------------------------------

				if(c=='\n'&&check==true&&s.Trim()!="") 
				{
					s+="\r\n";
				}
				else if((c=='<'||check==false)&&c!='>') 
				{
					if(c=='<'&&s1.Trim()!="")
						s+=s1;
					s1=s1+Source.Substring(i,1);
					check=false;
				}
				else if(c=='>') 
				{
					script="      ";
					style="     ";		
					check=true;
					s1="";
				}
				else if(check==true) 
				{
					s+=Source.Substring(i,1);
				}       
			}
			return s;

		}
		private int Find(string Source,string want)
		{
			string s=Source;
			int len=Source.Length-want.Length+1;
			if(s.Length<len) return -1;
			for(int i=0;i<len;i++) 
			{
				if(s.Substring(i,want.Length)==want) return i;
			}
			return -1;
		}
		public void MakeLinks(string Source,string URLLocation)
		{
			string script="       ";
			string Link="",Label="",base1="           ",href="     ";
			string source="",body="     ",root="",temp="",tempL="";
			string filter="          ";
			int len=Source.Length,dim=0;
			char c;
			bool check=false;
			for(int i=0;i<len;i++) 
			{
				temp="";	tempL="";
				c=Convert.ToChar(Source.Substring(i,1));
				base1=base1.Remove(0,1);		href=href.Remove(0,1); 
				body=body.Remove(0,1);		script=script.Remove(0,1);
				base1+=c; href+=c; body+=c;	script+=c;
				//------------ Remove java Script -------------------
				if(script.ToLower()=="<script") 
				{
					script="         ";
					while(script.ToLower()!="</script>") 
					{
						i++;
						c=Convert.ToChar(Source.Substring(i,1));
						script=script.Remove(0,1);
						script+=c;
					}
					script="       ";
					continue;
				}
				//------------ Get The Base Link --------------------
				if(base1.ToLower()=="<base href=") 
				{
					i++;
					c=Convert.ToChar(Source.Substring(i,1));
					while(c!='>'&&c!='"'&&c!=' ') 
					{
						source+=c;
						i++;
						c=Convert.ToChar(Source.Substring(i,1));
					}
					while(c!='>') 
					{
						i++;
						c=Convert.ToChar(Source.Substring(i,1));
					}
					continue;
				}
				if(body.ToLower()=="<body") 
				{
					while(c!='>') 
					{
						i++;
						c=Convert.ToChar(Source.Substring(i,1));
					}
					check=true;
					continue;
				}
				if(href.ToLower()=="href="&&check==true) 
				{
					i++;
					c=Convert.ToChar(Source.Substring(i,1));
					if(c!='"'&&c!='\'') //Link.Append(source);
						temp=source;  // base
					else { i++; c=Convert.ToChar(Source.Substring(i,1)); } 
					//--------- Get Links ----------------------
					while(c!='"'&&c!='\''&&c!='>') 
					{
						temp+=c;
						i++;
						c=Convert.ToChar(Source.Substring(i,1));
					}
					while(c!='>') 
					{
						i++;
						c=Convert.ToChar(Source.Substring(i,1));
					}
					int find=Find(temp,"http://");
					int find1=Find(temp.Substring(find+1,temp.Length-find-1),"http://");
					while(find1>=0) {
						temp=temp.Remove(0,find1+1);
						find=Find(temp,"http");
						find1=Find(temp.Substring(find+1,temp.Length-find-1),"http://");
					}
					if(temp!="") 
					{
						if((find=Find(temp,"http://"))>0)
						{
							temp=temp.Remove(find,temp.Length-find);
							if((find=Find(temp,"/*"))>0) 
								temp=temp.Remove(find,temp.Length-find);
						}
						if((find=Find(temp,"../"))==0)
							temp=URLLocation+temp;
						if(Convert.ToChar(temp.Substring(0,1))!='/')
							temp=source+temp;
						else if(Convert.ToChar(temp.Substring(0,1))=='/')
							temp=URLLocation+temp;
					}
					//-----------------------------------------------
					//------- Get Label -----------------------------
					string test="   ";
					bool tag=false;
					if(c=='<') tag=false;
					else if(c=='>') tag=true;
					while(test.ToLower()!="</a"&&test.ToLower()!="</t") 
					{
						i++;
						c=Convert.ToChar(Source.Substring(i,1));
						//----------------- &Ascii Char; -------------------
						filter+=c;
						if(c==';') 
						{
							//int find;
							if((find=Find(filter,"&"))>=0) 
							{
								filter=filter.Remove(0,find);
								string res=FilterAscii(filter.Trim());
								if(res!="NULL") 
								{
									find =filter.Length-1;
									c=Convert.ToChar(res.Substring(res.Length-1,1));
									tempL=tempL.Remove(tempL.Length-find,find);
									filter="          ";
									tempL+=c;
									continue;
								}
							}
						}
						filter=filter.Remove(0,1);
						//------------------------------------------
						test=test.Remove(0,1);
						if(c=='<') tag=false;
						else if(c=='>') tag=true;
						if(tag==true&&c!='>') tempL+=c;
						test+=c;
					}
					//-------------------------------------------------
					if((tempL=tempL.Trim())!=""&&(temp=temp.Trim())!="") 
					{
						Link+=temp;	Label+=tempL;
						root+=tempL+" --> "+temp+"\r\n";
						Link+="\r\n";	Label+="\r\n";
						dim++;
					}
				}
			}
			PLinks=new string[dim,1];
			PLabels=new string[dim,1];
			int row=0,j=0;
			for(int i=0;i<Link.Length;i++) 
			{
				c=Convert.ToChar(Link.Substring(i,1));
				if(c!='\n') PLinks[row,0]+=c;
				else 
				{
					for( ;j<Label.Length;j++) 
					{
						c=Convert.ToChar(Label.Substring(j,1));
						if(c!='\n') PLabels[row,0]+=c;
						else
						{
							row++;	j++; break;
						}
					}
				}
			}
		}
		public string FilterAscii(string Ascii)
		{
			for(int i=0;i<131;i++) 
			{
				if(Ascii==AsciiChar[i,0]||Ascii==AsciiChar[i,1])
					return AsciiChar[i,2];
			}
			return "NULL";
		}
		public string[,] GetLabels()
		{
			return PLabels;
		}
		public string[,] GetLinks()
		{
			return PLinks;
		}
	}
}
