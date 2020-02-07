class MyClass
			
end

class MyOtherClass < MyClass

end

def showFamily( aClass )	
	if (aClass != nil) then	
		puts( "#{aClass} :: about to recurse with aClass.superclass = #{aClass.superclass.inspect}" )			
		showFamily( aClass.superclass )
	end
end

# Try uncommenting these classes one by one to trace back through
# their family tree...

showFamily( MyOtherClass )
# puts
# showFamily( String )
# puts
# showFamily( File )
# puts
# showFamily( Object )
# puts
# showFamily( Class )



