# This is the Ruby equivalent of the Recursion 3 C project

def sumRecursion( callnum, n )	
	callnum += 1	
	puts "Enter \t\t#[#{callnum}]: SumRecursion(n=#{n})" 
	if n == 1 then
		total = 1
		puts "     --- End condition met! total=#{total} ---"
	else
		newnum = n - 1
		puts "  before\t#[#{callnum}]: SumRecursion(#{newnum})"
		total = n + sumRecursion( callnum, newnum ) 
		puts "  after\t\t#[#{callnum}]: total=#{total}"
	end
	puts( "Return: n=#{n}, total= #{total}" )	
	return total	
end

startnum = 3
puts "\nSum of the first #{startnum} integers using recursion is #{sumRecursion( 0, startnum )}" 