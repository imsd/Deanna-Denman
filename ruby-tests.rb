#puts 5
for i in 0..4
 # puts i
end


(0..4).each do |i|
  #puts i
end

a = [8, 7, 6, 5]
a.each do |i|
  #puts i
end

#for loop
for i in a
 # puts i
end

# while loop, while condition true loop
i = 0 
while i < 5
 # puts i
  i += 1
end


# keep looping when this condition is true
i = 0
until i == 5
  #puts i
  i +=1
end
=begin
#making a function
#adds the two arguments
def add (a,b)
  a+b
end
#hello calls add
def hello
  add(3,4)
end
#calls hello
#q= is the part that is calling the function
q = hello
puts q
=end
  
  def kelp(a,b)
    for i in a..b 
      puts i
    end
    "done"
  end
  
  r = kelp(1,9)
  puts r