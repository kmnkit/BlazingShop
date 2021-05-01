using BlazingShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public void LoadProducts()
        {
            Products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    CategoryId = 3,
                    Title="젤다의 전설 브레스 오브 와일드",
                    Description=@"광대한 세계를 무대로 어디로 가든, 무엇을 하든,
                                    모험의 모든 것을 당신이 원하는 대로 할 수 있습니다.
                                    야생 동물을 사냥하며 지낼 것인가? 몬스터를 퇴치하러 갈 것인가?
                                    절경 포인트를 보러 다닐 것인가?
                                    달리고, 헤엄치고, 날고, 높은 곳을 오르고,
                                    광활한 세계에서 본인이 마음먹은 대로 모험할 수 있습니다.
                                    Nintendo Switch를 통해, 자택의 TV로 느긋하게 플레이 하다가
                                    그대로 들고 나가 외출 중에도 계속해서 모험을 즐길 수 있는 등,
                                    자유로운 플레이 스타일로 즐길 수 있습니다.",
                    Image = "https://store.nintendo.co.kr/media/catalog/product/cache/8e3c84988db1fdb90470f4d01453d879/f/i/file.jpg",
                    Price = 70m,
                    OriginalPrice = 77m,
                },
                new Product{
                    Id = 2,
                    CategoryId = 3,
                    Title = "몬스터헌터 스토리즈2 파멸의 날개",
                    Description = @"
                        몬스터헌터 시리즈 RPG 제2탄!
                        맡겨진 것은 파멸인가 희망인가－

                        「몬스터헌터 스토리즈」는 몬스터와 유대관계를 맺고 키워 공존하는 「라이더」가 되어,
                        「몬스터헌터」의 세계를 모험할 수 있는 RPG입니다. 시리즈 제2탄인 본 타이틀에서는 새로운 인연의 이야기가 막을 엽니다.

                        [스토리]
                        모든 리오레우스가 어딘가로 날아가 버린 세계.

                        위대한 라이더 「레드」의 피를 받은 주인공은 알을 부탁받은 용인족 소녀 에나와 운명적으로 만나게 됩니다.
                        알에서 부화한 「리오레우스」는 전설대로 날개가 검고, 모습은 「파멸의레우스」 그 자체였습니다.

                        세계에서 일어나고 있는 이변과 전설의 진상을 확인하기 위해 주인공들은 파멸과 희망의 이야기를 이어 나가게 됩니다.
                    ",
                    Image = "https://store.nintendo.co.kr/media/catalog/product/cache/8e3c84988db1fdb90470f4d01453d879/3/9/39d22dad288b3e3dd75f63b7f757202d25fc10bcdd527192cbd19bcbbff7da64.jpg",
                    Price = 9.99m,
                    OriginalPrice = 19.99m,
                },
                new Product{
                    Id = 3,
                    CategoryId = 1,
                    Title = "New 포켓몬 스냅",
                    Description = @"
                        1999년 해외에서 NINTENDO64 소프트웨어로 발매한 『포켓몬 스냅』의
                        게임성을 기반으로 한 완전 신작이 Nintendo Switch로 등장!

                        미지의 땅 「렌틸지방」에서, 포켓몬들의 본 적이 없는 표정이나 행동을 발견하고,자신만의 베스트 숏을 촬영해 봅시다.

                        루트를 따라 자동으로 이동하는 「네오원」 안에서 야생 포켓몬들의 모습을 사진에 담을 수 있습니다.
                        눈에 띄지 않는 장소에 몸을 숨긴 포켓몬이나 갑자기 하늘에서 나타나는 포켓몬도 있습니다.
                        전설의 포켓몬과 환상의 포켓몬을 만날 수도 있습니다. 결정적인 순간을 포착할 수 있는지 없는지는 여러분 몫입니다.
                        많은 포켓몬의 사진을 계속해서 촬영하고, 자신만의 포켓몬 포토 도감을 만들어 봅시다!
                        게다가 찍은 사진을 가공하여 포켓몬 포토 도감과는 별도로 앨범에도 저장하여 즐길 수 있습니다.
                        또한 Nintendo Switch Online(유료) 이용의 고객은, 전세계의 사람들과 서로의 사진을 보여주거나 서로의 스코어를 겨룰 수도 있습니다.
                    ",
                    Image = "https://store.nintendo.co.kr/media/catalog/product/cache/8e3c84988db1fdb90470f4d01453d879/a/e/aee54cc82c8d80c969cf4ecd8843dad5568469cd4cd19cb863be2a08080e93cd.jpg",
                    Price = 8.19m,
                    OriginalPrice = 29.99m,
                },
                new Product{
                    Id = 4,
                    CategoryId = 2,
                    Title = "닌텐도 스위치 레드X블루",
                    Description = "닌텐도 스위치 새로 나온 디자인",
                    Image = "https://www.nintendo.co.kr/software/switch/35thmario/set/assets/img/modal-product-img.png",
                    Price = 360m,
                    OriginalPrice = 399.99m,
                },
                new Product{
                    Id = 5,
                    CategoryId = 2,
                    Title = "닌텐도 스위치 동물의숲 한정판",
                    Description = "동물의숲",
                    Image = "https://www.nintendo.co.kr/software/switch/acbaa/set/img/img-box.png",
                    Price = 360m,
                    OriginalPrice = 399.99m,
                },
                new Product{
                    Id = 6,
                    CategoryId = 1,
                    Title = "닌텐도 3D XL",
                    Description = "생산 종료되었습니다.",
                    Image = "https://www.nintendo.co.kr/images/renew/3ds/new3ds/nintendo_new_3ds_xl.png",
                    Price = 200m,
                    OriginalPrice = 220m,
                }
            };
        }
    }
}
