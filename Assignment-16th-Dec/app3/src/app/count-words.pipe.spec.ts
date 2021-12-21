import { CountWordsPipe } from './count-words.pipe';

describe('CountWordsPipe', () => {
  it('create an instance', () => {
    const pipe = new CountWordsPipe();
    expect(pipe).toBeTruthy();
  });
});
