(double area, double perimeter) CalculateRectangle(double length, double width){
    double area = length*width;
    double perimeter = 2*(length+width);
    return(area,perimeter);
}
    Console.WriteLine("output:"+ CalculateRectangle(20,3));

