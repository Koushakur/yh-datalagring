
using Shared.Entities;
using Shared.Repositories;
using System.Diagnostics;

namespace Shared.Services;

public class CurrencyService(CurrencyRepository currencyRepository) {
    private readonly CurrencyRepository _currencyRepository = currencyRepository;

    public bool Create(string isoCode, string name, string symbol) {

        try {
            if (!_currencyRepository.Exists(x => x.ISOCode == isoCode)) {
                var tCurrency = new CurrencyEntity {
                    ISOCode = isoCode,
                    Name = name,
                    Symbol = symbol
                };

                _currencyRepository.Create(tCurrency);

                return true;
            }

        } catch (Exception e) { Debug.WriteLine(e); }

        return false;
    }

    public IEnumerable<CurrencyEntity> GetAll() {
        return _currencyRepository.GetAll();
    }

    public CurrencyEntity GetOne(string isoCode) {
        return _currencyRepository.GetOne(x => x.ISOCode == isoCode);
    }

    public bool UpdateImage(string isoCode, CurrencyEntity updatedEntity) {
        return _currencyRepository.UpdateEntity(x => x.ISOCode == isoCode, updatedEntity);
    }

    public bool RemoveImage(string isoCode) {
        return _currencyRepository.RemoveEntity(x => x.ISOCode == isoCode);
    }
}

