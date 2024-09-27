
public double dif(double x, double y)
{
	return x-y;
}


static double CalculateDistance3Dxyz(float x1, float y1, float z1, float x2, float y2, float z2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    }
	
	
public class particle
{
	//mass
	public double m;
	//coordinate
	public double x;
	public double y;
	public double z;
	
	
}
public List<particle> p= new List<particle>();


//adauga 3 particule
public void add3particleinlist()
{
	p.Add(new particle());
	p.Add(new particle());
	p.Add(new particle());
}

public void calculateAllDistances()
{

		//calculeaza distantele pentru toate distantele intre cele 3 particule
		r12 = CalculateDistance(p[0].x, p[0].y, p[0].z,p[1].x, p[1].y, p[1].z);
		r13 = CalculateDistance(p[0].x, p[0].y, p[0].z,p[2].x, p[2].y, p[2].z);
		r32 = CalculateDistance(p[1].x, p[1].y, p[1].z,p[2].x, p[2].y, p[2].z);
		
	
	
}

public void ecuationsOfMotions()
{
	//k gravity constant
	double k = 9.8;
	double kk = k*k;
	double dd = d*d;
	double t = 0;
	double tt =t*t;
	
	double r12x3 = r12*r12*r12;
	double r13x3 = r13*r13*r13;
	double r23x3 = r23*r23*r23;
	
	mo1 =  (kk*p[1].m * ((q2i-q1i)/(r12x3)))+ (kk*p[2].m*((q3i-q1i)/(r13x3)));
	mo1b = (dd*q1i)/(d*(tt));
	
	mo2 =  (kk*p[0].m * ((q1i-q2i)/(r12x3)))+ (kk*p[2].m*((q3i-q2i)/(r13x3)));
	mo2b = (dd*q2i)/(d*(tt));
	
	mo3 =  (kk*p[0].m * ((q1i-q3i)/(r13x3)))+ (kk*p[1].m*((q2i-q3i)/(r23x3)));
	mo3b = (dd*q3i)/(d*(tt));
	
	
	
	
}

public double potentialEnergyVofWholeSystem()
{
		return ((m2*m3)/r23) - ((m3*m1)/r31) - ((m1*m2)/r12);
	
}

public double pij()
{
	return mi(((d*qij)/(d*t)));
	
}

public double H()
{
	double s = 0;
	for(int i = 0 ; i < 3 ; i++)
	{
		s += (pij*pij)/(2*mi))+V;
	}		
	return s;
}


		public double q1i ;
		public double q2i ;
		public double q3i ;
		
		public double mo1;
		public double mo2;
		public double mo3;
	
		public double r12 ;
		public double r13 ;
		public double r23 ;
	
	
		public double mo1b;
		public double mo2b;
		public double mo3b;
		

public class sp
{
		
}
 	