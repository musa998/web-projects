import { Component, OnInit } from '@angular/core';
import { MovieService} from '../service/movie.service';
import  Movie   from '../models/Movie';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-movies',
  templateUrl: './movies.component.html',
  styleUrls: ['./movies.component.css']
})
export class MoviesComponent implements OnInit {

  popular$: Observable<Movie[]>;
  theaters: Observable<Movie[]>;
  popularMovies: Array<Movie>;

    constructor(private movieService: MovieService) {
    
     
   }

  ngOnInit() {
    console.log("just text");
    this.movieService.getPopular().subscribe(data => {
      this.popularMovies = data['results'];
    })
     this.popular$ = this.movieService.getPopular();
     console.log(this.popular$);
  }

}
