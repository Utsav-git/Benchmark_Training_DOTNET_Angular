import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DivisionPipeComponent } from './division-pipe/division-pipe.component';
import { DivisionPipePipe } from './division-pipe.pipe';
import { FormsModule } from '@angular/forms';
import { StrFormatComponent } from './str-format/str-format.component';
import { StrFormatPipe } from './str-format.pipe';
import { NumberOfWordsStringComponent } from './number-of-words-string/number-of-words-string.component';
import { CountWordsPipe } from './count-words.pipe';
import { RepeatWordsComponent } from './repeat-words/repeat-words.component';
import { RepeatWordPipe } from './repeat-word.pipe';
import { PersonDisplayComponent } from './person-display/person-display.component';

@NgModule({
  declarations: [
    AppComponent,
    DivisionPipeComponent,
    DivisionPipePipe,
    StrFormatComponent,
    StrFormatPipe,
    NumberOfWordsStringComponent,
    CountWordsPipe,
    RepeatWordsComponent,
    RepeatWordPipe,
    PersonDisplayComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
