import { Component, OnInit, Input } from '@angular/core';
import Movie from '../models/Movie';

@Component({
  selector: 'app-movie',
  templateUrl: './movie.component.html',
  styleUrls: ['./movie.component.css']
})
export class MovieComponent implements OnInit {
  @Input('movie')
  movie: Movie;
  imagePath: string;
  
  constructor() { }

  ngOnInit() {
    console.log('Some Movie TITTLE' + this.movie);
    this.imagePath = "http://image.tmdb.org/t/p/w500/" + this.movie.poster_path;
    //console.log( "IMAGE URL -------------- " +this.imagePath);
    
  }

}
