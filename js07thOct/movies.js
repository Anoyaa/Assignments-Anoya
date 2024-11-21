const movies=[
    {
      "MovieName": "The Great Adventure",
      "ActorName": "John Smith",
      "ReleaseDate": "2023-01-15"
    },
    {
      "MovieName": "Mystery in the Woods",
      "ActorName": "Emily Johnson",
      "ReleaseDate": "2022-09-28"
    },
    {
      "MovieName": "Love and Destiny",
      "ActorName": "Michael Brown",
      "ReleaseDate": "2023-05-02"
    },
    {
      "MovieName": "City of Shadows",
      "ActorName": "Sophia Williams",
      "ReleaseDate": "2023-03-12"
    },
    {
      "MovieName": "The Last Stand",
      "ActorName": "William Davis",
      "ReleaseDate": "2022-11-07"
    },
    {
      "MovieName": "Echoes of Time",
      "ActorName": "Olivia Wilson",
      "ReleaseDate": "2022-12-19"
    }
  ]

const movie22=movies.filter(x=>new Date(x.ReleaseDate).getFullYear()===2022).map(movie=>`${movie.ActorName} ${movie.MovieName}`);
console.log(movie22);

const mov23willdavis=movies.filter(mov=>mov.ActorName==='William Davis' && new Date(mov.ReleaseDate).getFullYear()===2023);
console.log(mov23willdavis); 

const laststand=movies.filter(mov=>mov.MovieName==='The Last Stand').map(mov=>`${mov.ActorName},${mov.ReleaseDate}`);
console.log(laststand);

 const johndoemov=movies.some(mov=>mov.ActorName==='John Doe');
 console.log("the statement that movie with actor name John Doe is present is "+johndoemov);

const countmov=movies.filter(mov=>mov.ActorName==='Sophia Williams');
console.log(countmov.length);

movies.push(	{
       "MovieName": "The Final Stage",
       "ActorName": "John Doe",
       "ReleaseDate": "2022-08-11"
       });
 console.log(movies);

 const dupli=new Set(movies).size!==movies.length;
 console.log("the array has duplicate values?: "+ dupli);

  const index=movies.findIndex(mov=>mov.MovieName=='City Of Shadows');
  const newmovieslist=movies.slice(index,movies.length);
  console.log(newmovieslist); 

const uniqueval=new Set(movies.map(mov=>mov.ActorName));
 console.log(uniqueval);


 const newmov =
     {
         "MovieName": "Rich & Poor",
         "ActorName": "Johnie Walker",
         "ReleaseDate": "2023-08-11"
   }
 ;
 const ind=movies.findIndex(mov=>mov.MovieName==='Love and Destiny');
 movies.splice(ind+1,0,newmov);
 console.log(movies);

const uniqnew=new Set(movies.map(mov=>mov.ActorName));
console.log(uniqnew.size);

const indexnew=movies.findIndex(mov=>mov.MovieName==='The Last Stand');
const newrem=movies.splice(indexnew,1);
console.log(movies);


const afterdate=movies.filter(mov=>mov.ReleaseDate>'2021-12-31');
console.log(afterdate);

const indexdate=movies.findIndex(mov=>mov.MovieName==='City of Shadows');
movies[indexdate].ReleaseDate='2023-03-13';
console.log(movies);

const movlength=movies.filter(mov=>mov.ActorName.length>10);
console.log(movlength);