
$total = 0

def sumRecursion( n )
	n += 1
	$total +=1
	puts( "n is #{n}, $total is #{$total}" )
	if $total < 3 then
		sumRecursion( n ) 
	end
	puts( "...n is #{n}, $total is #{$total}" )		
end

puts( "At START: $total is #{$total}" )	
sumRecursion( 0 ) 
puts( "At END: $total is #{$total}" )		
