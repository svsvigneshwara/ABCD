import { MODTemplatePage } from './app.po';

describe('MOD App', function() {
  let page: MODTemplatePage;

  beforeEach(() => {
    page = new MODTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
