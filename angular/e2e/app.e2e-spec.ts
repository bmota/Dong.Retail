import { RetailPage } from './app.po';

describe('abp-zero-template App', function () {
    let page: RetailPage;

    beforeEach(() => {
        page = new RetailPage();
    });

    it('should display message saying app works', () => {
        page.navigateTo();
        page.getCopyright().then(value => {
            expect(value).toEqual(new Date().getFullYear() + ' © Retail.');
        });
    });
});
