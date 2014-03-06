﻿using System.Linq;
using eZet.EveLib.EveOnlineLib.Model;
using eZet.EveLib.EveOnlineLib.Model.Account;

namespace eZet.EveLib.EveOnlineLib {
    public class CorporationKey : ApiKey {
        private Corporation _corporation;

        public CorporationKey(long keyId, string vCode)
            : base(keyId, vCode) {
        }

        public Corporation Corporation {
            get {
                if (_corporation == null)
                    lazyLoad();
                return _corporation;
            }
            private set { _corporation = value; }
        }

        protected override void lazyLoad() {
            EveApiResponse<ApiKeyInfo> info = GetApiKeyInfo();
            load(info);
            Corporation = new Corporation(this, info.Result.Key.Characters.First().CorporationId,
                info.Result.Key.Characters.First().CorporationName);
        }
    }
}