import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-division-pipe',
  templateUrl: './division-pipe.component.html',
  styleUrls: ['./division-pipe.component.css']
})
export class DivisionPipeComponent implements OnInit {

  a: number = 0;
  b: number = 0;
  constructor() { }

  ngOnInit(): void {
  }

}
