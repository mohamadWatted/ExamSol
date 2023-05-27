//----2-سؤال---أ----//

	public static bool IsAccept(char ch,int num1,int num2)
		{
			if(ch=='A')
				if(num1==4||num1==5&&num2>500)
				{ return true; }
			if(ch=='B') 
			  if(num1==6||num1==7&&num2>400)
				{ return true; }
			return false;
		}
		//-----2--سؤال--ب-----//
          public void Count()
		{
			int num,numPoints;
			char ch;
			int count1=0,count2=0;
			for(int i=1;i<=200;i++)
			{
				ch=char.Parse(Console.ReadLine());
				num=int.Parse(Console.ReadLine());
				numPoints=int.Parse(Console.ReadLine());
				if(ch=='A')
					if(IsAccept(ch,num,numPoints))
						count1++;
				else if(ch=='B')
						if(IsAccept(ch,num,numPoints))
							count2++;
			}
            Console.WriteLine(count1+","+count2);
        }

		//----3--أ--سؤال-//
		public static int Compare(string name1, string name2,int age1,int age2)
		{
			if (name1[0] == name1[name1.Length - 1] && name2[0] == name2[name2.Length - 1] &&
				name1.Length == name2.Length && age1 == age2)
				return 1;
			return 0;
		}

		//----3--ب--سؤال-//

		public void Count2()
		{
			string name1,name2;
			int age1,age2;
			int count = 0;
			name1 = Console.ReadLine();
			name2 = Console.ReadLine();
			while(name1!="End" && name2 != "End")
			{
				age1 = int.Parse(Console.ReadLine());
				age2 = int.Parse(Console.ReadLine());
				if(Compare(name1,name2,age1,age2)==1)
					count++;
				name1 = Console.ReadLine();
				name2 = Console.ReadLine();
			}
			Console.WriteLine(count);
		}




//--------------سؤال 4-------//

//أ
  public class BusLine{
	  private int lineNum;
	  private BusStation [] stopArr;
	  private int maxStations;
	  private int numStations;
//ب

   public BusLine(int lineNum,int numStations)
   {
	   this.lineNum=lineNum;
	   this.stopArr=new BusStation[maxStations];
	   this.numStations=numStations;
   }
   
//ج
   public bool AddStation(BusStation busStation)
   {
	   if(this.numStations>=stopArr.Length)
		   return false;
	   this.stopArr[numStations]=busStation;
	   this.numStations++;
	   return true;
   }
 //ث
  
  public bool FindStop(string stationName)
  {
	  for(int i=0;i<this.numStations;i++)
	  {
		  if(this.stopArr[i].GetStationName()==stationName)
			  return true;
	  }
	  return false;
	  
  }
   
   
   
//ج
   public static int TravelCost(BusLine busLine)
   {
	   int sumPrice=0;
	   BusStation [] arr=busLine.GetArr();
	   for(int i=0;i<arr.Length-1;i++)
	   {
		   if(arr[i].GetCityName()==arr[i+1].GetCityName()
			   sum+=5;
		   else 
			   sum+=15;
	   }
	   return sum;
	   
   }
	  
	 
	 
	 //---------سؤال 5-----//
	 //أ
	   
	   public class House{
		   private int numRooms;
		   private double area;
		   private string address;
		   private bool rent;
		   
		public House(int numRooms,double area,string address,bool rent)
		{
			this.numRooms=numRooms;
			this.area=area;
			this.address=address;
			this.rent=rent;
		}
	//ب
	//1
	   public class HouseDB{
		   private House [] arrHouse;
		   private int numHouses;
		   
	//2
	   public bool Add(House house)
	   {
		   if(numHouses>=arrHouse.Length)
			   return false;
		   this.arrHouse[numHouses]=house;
		   this.numHouses++;
		   return true;
	   }
     //3
	   public int[] Search(int n)
	   {
		   int count;
		   for(int i=0;i<this.numHouses;i++)
			   if(this.arrHouse.GetNumRooms()==n)
				   count++;
          House [] arr=new House[count];
		  int j=0;
          for(int i=0;i<this.numHouses;i++)
		  {   if(this.arrHouse.GetNumRooms()==n)   
			      arr[j]=this.arrHouse[i];
			      j++;
		  }
		  return arr;
	   }
	
	
 //--------سؤال 6-----//	
 //أ
    public class Theater{
		public int const maxSize=100;
		private string theaterName;
		private int len;
		private Actor[]arAct;
		private int current;
		
//ب
     public int Count(int num)
	 {
		 int count=0;
		 for(int i=0;i<this.current;i++)
		 {
			 if(this.arAct[i].GetAge()>num)
				 count++;
		 }
		 return count;
	 }
	 
//ج
     public string Max()
	 {
		 int max=this.arAct[0].GetNumAct();
		 string maxName=this.arAct[0].GetName();
		 
		 for(int i=1;i<this.current;i++)
		 {
			 if(this.arAct[i].GetNumAct()> max)
			 {
				 max=this.arAct[i].GetNumAct();
				 maxName=this.arAct[i].GetName();
			 }
		 }
		 return maxName;
	 }