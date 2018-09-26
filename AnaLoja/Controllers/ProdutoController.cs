using AnaLoja.Data.Entities;
using AnaLoja.Data.Repository;
using System.Net;
using System.Web.Mvc;


namespace AnaLoja.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly ProdutoRepository _produtoRepository;

        public ProdutoController()
        {
            _produtoRepository = new ProdutoRepository();
        }
        // GET: Produtos
        public ActionResult Index()
        {
            return View(_produtoRepository.ObterTodos());
        }

        // GET: Produtos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto produto = _produtoRepository.ObterPorId(id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }

        // GET: Produtos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Produtos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Descricao,Categoria,Preco")] Produto produto)
        {
            if (ModelState.IsValid)
            {
                _produtoRepository.Salvar(produto);
                return RedirectToAction("Index");
            }

            return View(produto);
        }

        // GET: Produtos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto produto = _produtoRepository.ObterPorId(id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }

        // POST: Produtos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Descricao,Categoria,Preco")] Produto produto)
        {
            if (ModelState.IsValid)
            {
                _produtoRepository.Atualizar(produto);
                return RedirectToAction("Index");
            }
            return View(produto);
        }

        // GET: Produtos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto produto = _produtoRepository.ObterPorId(id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }

        // POST: Produtos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _produtoRepository.Remover(id);
            return RedirectToAction("Index");
        }
    }
}
